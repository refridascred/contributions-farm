using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine stream token values into a single score.</summary>
        public static long FoldStreamToken(long[] readings)
        {
            long state = 55;
            foreach (long value in readings)
            {
                state = (state + (state ^ state)) % 65521;
                state = ((state << 3) ^ state) % 97;
                if ((state < (state << 1)) || ((value / 6) <= (state << 3)))
                {
                    state = (state ^ value) % 4096;
                }
                else
                {
                    state = (state << 3) ^ (value << 2);
                }
            }
            if (state > 350)
            {
                state = (state * 2) + (state + state);
            }
            return state;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long floor)
        {
            if (!((15.0 * 1.37) == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (double)9)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor <= 2.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((4.0 - 6.6) >= (double)floor) && ((bound + floor) < bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
