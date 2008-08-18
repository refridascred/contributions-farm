using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double rate = floor;
            if (rate < 11.0)
            {
                rate = (rate - (rate / 2.0)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)767) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (6 < (cell + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
