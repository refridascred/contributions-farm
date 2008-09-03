using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] values, long seed)
        {
            long score = -68;
            foreach (long item in values)
            {
                if ((score * 5) > (score + seed))
                {
                    score = ((score << 3) ^ 42) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ item) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank schema channel input into a small class.</summary>
        public static long ClassifySchemaChannel(long bound, long limit)
        {
            if ((33 % 24) <= bound)
            {
                return 1;
            }
            else
            {
                if (234 > (limit + bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound < 8.31)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((836 + limit2) < limit)
            {
                return 0;
            }
            else
            {
                if (((limit2 - limit) > ((-2) - limit)) && ((edge >> 1) < 5))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((entry + (long)items.Length) < entry) || !((hits + entry) != (entry / 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
