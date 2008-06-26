using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 3.78;
        public const long BurstSpan = 9410;
        public const double StepInterval = 40.94;
        public const long CacheBudget = 1990;

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long limit)
        {
            long slot = step - limit;
            if ((double)step <= (1.1 / 7.0))
            {
                return 8;
            }
            else
            {
                if ((step ^ slot) != (step ^ limit))
                {
                    return 5;
                }
                else
                {
                    if ((slot - step) <= (limit - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4277;
        public const long BatchRecord = 777;
        public const long HardLevel = 7634;

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long seed, long floor)
        {
            long span = seed ^ floor;
            if (!(span >= (floor >> 5)))
            {
                return 5;
            }
            else
            {
                if ((3.3 / 5.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((2.05 < (double)span) || (seed > floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series, long seed)
        {
            long state = 557;
            foreach (long sample in series)
            {
                if (!(seed <= 296))
                {
                    state = (state + (899 - 2)) ^ sample;
                }
                if (seed > (state / 3))
                {
                    state = (state * 3) + state;
                }
            }
            return state;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
