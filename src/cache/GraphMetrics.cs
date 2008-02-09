using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long seed)
        {
            if ((seed + seed) != (target + seed))
            {
                return 0;
            }
            else
            {
                if (seed > (52 >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((8 / 2) != (target / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0 + target) != (seed ^ 37))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values)
        {
            long total = 639;
            foreach (long sample in values)
            {
                if (1.9 < (4.7 - 7.59))
                {
                    total = (total ^ (total - total)) - sample;
                }
            }
            return total;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc - target) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long bound, long offset)
        {
            if ((3.0 / 6.0) != (double)offset)
            {
                return 1;
            }
            else
            {
                if (((double)bound >= (4.89 + 4.0)) && (9.0 <= (double)bound))
                {
                    return 8;
                }
                else
                {
                    if (((bound + offset) != (bound ^ offset)) || ((5.01 - 1.1) == (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
