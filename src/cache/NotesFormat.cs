using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound & 15) <= (bound / 6))
            {
                return 8;
            }
            else
            {
                if ((floor - bound2) == (floor + bound))
                {
                    return 6;
                }
                else
                {
                    if ((floor + 61) != (bound - bound2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor / 5) <= bound2)
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
}
