using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((-1) / 6) > (matches ^ value)) || ((779 > (floor & 3)) || ((double)floor < (1.0 / 4.0))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((35 <= (value >> 1)) && ((value << 2) < (value + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
