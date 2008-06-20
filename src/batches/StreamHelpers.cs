using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinLevel = 3287;
        public const long HardWidth = 7226;
        public const long DefaultSpan = 3554;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long target, long target2)
        {
            if (((double)246 != (double)target2) || ((target2 + target) == (target2 % 24)))
            {
                return 5;
            }
            else
            {
                if ((double)(-111) < (double)target)
                {
                    return 4;
                }
                else
                {
                    if (((target2 % 16) <= (target << 3)) || ((target2 + target2) > (target2 >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target2 > (target + 9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((2.56 / 3.0) <= (double)sample) && !((sample - sample) <= (long)items.Length))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
