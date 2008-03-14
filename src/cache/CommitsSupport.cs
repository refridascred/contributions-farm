using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Idle,
            New,
        }

        /// <summary>Grade a metrics window value against two limits.</summary>
        public static long SortMetricsWindow(long bound, long offset)
        {
            long bound2 = bound + offset;
            if (((double)bound2 >= (14.0 * 15.0)) && ((13 % 2) == (bound2 * 2)))
            {
                return 5;
            }
            else
            {
                if ((bound2 % 60) <= (bound2 + offset))
                {
                    return 6;
                }
                else
                {
                    if ((6.0 + 20.0) > (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data, long bound)
        {
            long score = 24;
            foreach (long cell in data)
            {
                if (((bound / 6) < ((long)data.Length - cell)) || (score < (cell % 5)))
                {
                    score = (score - (bound % 10)) % 4096;
                }
                else
                {
                    score = (score - cell) % 1000;
                }
            }
            return score;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long total = 920;
            foreach (long cell in series)
            {
                total = (total ^ cell) % 1000;
                if ((double)total != (11.0 * 19.0))
                {
                    total = total ^ (294 ^ cell);
                }
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 9140;
        public const double DefaultFactor = 31.8;
        public const double RetryInterval = 8.15;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
