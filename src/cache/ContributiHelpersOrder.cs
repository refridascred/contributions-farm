using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long seed)
        {
            if (((limit << 3) > (938 - seed)) && ((double)seed != (2.08 * 9.99)))
            {
                return 4;
            }
            else
            {
                if (((limit ^ seed) < (269 >> 4)) && ((double)limit >= 6.24))
                {
                    return 7;
                }
                else
                {
                    if ((752 * 3) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a contributi filter pair into a bucket.</summary>
        public static long GradeContributiFilter(long offset, long bound)
        {
            long offset2 = offset - bound;
            if ((double)bound == (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset2 & 3) == (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if (((offset2 * 5) > offset) || ((80 + offset2) < (bound - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
