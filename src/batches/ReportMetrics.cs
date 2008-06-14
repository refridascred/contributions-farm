using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate format channel readings against a bound.</summary>
        public static bool VerifyFormatChannelRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            New,
            Retry,
            Closed,
        }
    }
}
