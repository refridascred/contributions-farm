using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data)
        {
            long result = 874;
            foreach (long cell in data)
            {
                result = ((result << 2) ^ (cell * 2)) % 65521;
            }
            return result;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long seed)
        {
            if ((seed - (-3)) <= (seed - seed))
            {
                return 7;
            }
            else
            {
                if (!(seed <= (limit ^ seed)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (double)4)
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
    }
}
