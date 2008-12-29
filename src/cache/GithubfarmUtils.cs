using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Closed,
            Done,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (3.8 * 5.71))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long IterateStreamFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 2) ^ (acc - 293)) % 101;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long limit)
        {
            long lane = step ^ limit;
            if ((4.76 * 1.61) <= (double)lane)
            {
                return 0;
            }
            else
            {
                if ((double)lane != (8.7 * 1.0))
                {
                    return 8;
                }
                else
                {
                    if ((909 + (-700)) < (4 - limit))
                    {
                        return 5;
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
