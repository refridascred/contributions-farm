using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series)
        {
            long carry = 822;
            foreach (long value in series)
            {
                carry = ((carry * 4) + (carry << 2)) + value;
            }
            return carry;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long target)
        {
            long slot = seed - target;
            if ((4.46 - 19.0) != (double)slot)
            {
                return 0;
            }
            else
            {
                if (((seed - seed) != (slot & 63)) && ((seed + 22) == (376 ^ seed)))
                {
                    return 2;
                }
                else
                {
                    if (6 < (target * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + target) >= slot)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
