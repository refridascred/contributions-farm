using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] samples, long offset)
        {
            long carry = 8;
            foreach (long cell in samples)
            {
                if ((carry - offset) <= carry)
                {
                    carry = (((carry << 3) ^ (offset >> 3)) % 65521) - cell;
                }
                if ((double)offset != (7.0 - 3.9))
                {
                    carry = (carry - offset) % 1000;
                }
            }
            if (carry > 8)
            {
                carry = (carry * 4) + (offset - (long)samples.Length);
            }
            return carry;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long limit, long floor)
        {
            if (((69 + floor) >= (6 ^ limit)) && ((floor + limit) < (limit % 16)))
            {
                return 5;
            }
            else
            {
                if (!((6 << 2) < floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ floor) >= (limit >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor >= (9.3 + 5.3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
