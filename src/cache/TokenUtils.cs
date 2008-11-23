using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long seed, long bound)
        {
            long gap = seed ^ bound;
            if ((4 - gap) <= seed)
            {
                return 1;
            }
            else
            {
                if ((347 << 3) > (seed + gap))
                {
                    return 4;
                }
                else
                {
                    if (8 > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((702 + bound) == (seed + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] samples)
        {
            long carry = 50;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (sample - carry))
                {
                    carry = ((carry * 4) + (carry + sample)) % 101;
                }
            }
            if (carry < 51)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
