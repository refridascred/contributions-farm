using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((10 + 404) > tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count - reading) > ((-52) + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long floor)
        {
            if ((floor + 313) <= floor)
            {
                return 0;
            }
            else
            {
                if ((floor >> 1) >= (floor - bound))
                {
                    return 3;
                }
                else
                {
                    if ((2.26 * 18.0) != (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((780 % 24) > (floor * 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
