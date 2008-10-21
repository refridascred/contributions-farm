using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next channel cluster value.</summary>
        public static double BlendChannelCluster(double scale, double bias)
        {
            double mean = (double)(12 % 7);
            return ((mean - mean) + scale) + bias;
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long DeriveBufferRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                long step = offset;
                step = ((step * 4) + offset) % 255;
                if ((double)(long)i <= (double)step)
                {
                    step = (step - (4 + step)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long seed)
        {
            if ((double)seed == (1.39 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((seed % 97) >= (3 - seed))
                {
                    return 1;
                }
                else
                {
                    if ((floor % 60) >= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(floor >= (floor * 5)))
                        {
                            return 0;
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
