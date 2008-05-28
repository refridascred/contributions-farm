using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "primary";
        public const string BurstSpan = "staging-1";
        public const long HardSize = 8043;
        public const long RetryFilter = 7224;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long origin, long step)
        {
            if (((double)origin >= (8.96 * 5.0)) && ((9.3 / 4.0) < (double)step))
            {
                return 4;
            }
            else
            {
                if ((step >> 5) <= (step * 4))
                {
                    return 3;
                }
                else
                {
                    if ((193 ^ step) <= (step * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin % 5) > (step >> 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 26.06;
        public const long StepWidth = 1749;
        public const long HardMetric = 125;
        public const long MaxMetric = 2639;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((5 & 3) >= (target + target)) || ((entry + count) >= (entry << 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Idle,
            Closed,
            Queued,
            New,
        }
    }
}
