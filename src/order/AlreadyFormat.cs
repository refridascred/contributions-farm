using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ ((long)i << 3)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a cache farm value against two limits.</summary>
        public static long GradeCacheFarm(long floor, long bound)
        {
            if (((double)bound >= (9.0 + 5.0)) || (floor > (bound - bound)))
            {
                return 0;
            }
            else
            {
                if ((5.0 - 16.0) <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((bound - floor) <= (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((5.0 / 8.0) <= (double)tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long step)
        {
            if ((seed + 752) <= (seed + 19))
            {
                return 7;
            }
            else
            {
                if (step <= (step / 4))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
