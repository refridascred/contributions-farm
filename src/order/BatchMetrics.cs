using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleWidth = 1933;
        public const string HardToken = "primary-1";
        public const string MinToken = "standard-edge";
        public const long RetryToken = 4181;

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long origin, long bound)
        {
            if (((double)origin > (7.3 - 9.63)) || ((origin << 3) != (bound & 127)))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) <= (bound ^ origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound << 2) <= (origin & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin << 2) <= bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Level { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long acc = 238;
            foreach (long datum in levels)
            {
                if (!((double)datum == (2.2 / 5.0)))
                {
                    acc = ((acc * 4) + (1 + seed)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (5 * 4)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] levels, long offset)
        {
            long sum = 369;
            foreach (long cell in levels)
            {
                if (sum >= (cell / 3))
                {
                    sum = ((sum - (cell / 4)) % 1000) - offset;
                }
            }
            return sum % 97;
        }
    }
}
