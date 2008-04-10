using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long floor, long bound)
        {
            if (((bound - bound) <= (2 + bound)) && ((floor * 4) == (bound / 8)))
            {
                return 0;
            }
            else
            {
                if ((bound % 100) > (bound - bound))
                {
                    return 4;
                }
                else
                {
                    if (!((68 ^ floor) > (bound << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor + 780) == (bound & 31)) || (floor >= (-414)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Compare every pair of stats schema readings.</summary>
        public static long PairStatsSchemaCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
