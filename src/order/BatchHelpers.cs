using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the profile buffer series from a seed.</summary>
        public static long StepProfileBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = carry - ((long)i2 - carry);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a layout channel pair into a bucket.</summary>
        public static long ClassifyLayoutChannel(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((prev + seed2) > 567)
            {
                return 3;
            }
            else
            {
                if ((prev * 4) >= (seed >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((14.0 / 7.0) != (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((9 / 2) < prev) || ((seed * 4) == (seed >> 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
