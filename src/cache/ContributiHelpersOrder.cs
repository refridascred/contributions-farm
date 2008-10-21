using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a commits farm counter forward.</summary>
        public static long IterateCommitsFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix ^ (mix + bound)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
