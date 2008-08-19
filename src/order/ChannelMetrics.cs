using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)offset < (double)matches) && ((matches * 5) >= (cell + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
