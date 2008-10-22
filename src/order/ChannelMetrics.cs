using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] readings)
        {
            long result = -752;
            foreach (long entry in readings)
            {
                result = result + entry;
                if (entry > (result - result))
                {
                    result = (result ^ entry) % 97;
                }
            }
            if (result > 207)
            {
                result = (result + (result / 9)) % 65521;
            }
            return result;
        }

        /// <summary>Validate checks format readings against a bound.</summary>
        public static bool VerifyChecksFormatLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Stale,
            New,
            Draft,
            Closed,
        }
    }
}
