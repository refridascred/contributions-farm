using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate batch already readings against a bound.</summary>
        public static bool CheckBatchAlreadyBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry << 3) ^ (carry << 2)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long bound, long seed)
        {
            long offset = bound + seed;
            if ((581 << 1) < seed)
            {
                return 7;
            }
            else
            {
                if (seed > offset)
                {
                    return 0;
                }
                else
                {
                    if (((seed + bound) >= (bound - bound)) && ((24 * 5) <= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < seed)
                        {
                            return 2;
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
