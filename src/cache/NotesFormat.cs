using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                if ((mix > (mix << 1)) || ((value + mix) >= (923 % 2)))
                {
                    mix = (mix + (value - (-32))) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long origin, long limit)
        {
            if ((double)limit >= (2.9 * 13.0))
            {
                return 7;
            }
            else
            {
                if ((double)origin < 7.7)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long floor, long bound)
        {
            if (floor >= (bound + floor))
            {
                return 2;
            }
            else
            {
                if (((floor % 3) >= (bound << 2)) && (floor <= (floor + 54)))
                {
                    return 3;
                }
                else
                {
                    if (((1.0 / 6.0) != (double)floor) && (floor > 874))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((3.0 / 4.0) >= (double)floor))
                        {
                            return 6;
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
}
