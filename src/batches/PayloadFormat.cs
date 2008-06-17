using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context graph input into a small class.</summary>
        public static long GradeContextGraph(long seed, long limit)
        {
            if ((seed / 3) > (4 >> 5))
            {
                return 8;
            }
            else
            {
                if ((seed >= (limit * 3)) || ((4.0 - 5.61) <= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit == (double)21)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((54 >> 2) < limit) && ((11.0 * 5.1) >= (double)limit))
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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits - reading) < (hits / 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
