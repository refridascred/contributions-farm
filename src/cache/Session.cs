using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples, long step)
        {
            long carry = 312;
            foreach (long item in samples)
            {
                carry = (((carry << 3) ^ (item + item)) % 4096) - step;
            }
            if (carry < 95)
            {
                carry = ((carry * 3) + (22 >> 3)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long target, long seed)
        {
            if ((double)target < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((double)target > (14.0 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((target < ((-39) / 3)) || ((seed + target) > (seed >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate order graph readings against a bound.</summary>
        public static bool GuardOrderGraphBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = (result * 2) + (218 - 6);
                result = (result + (26 * 3)) % 65521;
                if (!((bound >> 5) > result))
                {
                    result = (result - result) % 101;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
