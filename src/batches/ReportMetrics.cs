using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long CountContributiFormatHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (sample > (226 >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
