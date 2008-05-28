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

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long limit)
        {
            long state = 93;
            foreach (long datum in data)
            {
                state = ((state ^ (state % 7)) - datum) - limit;
            }
            return state;
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
