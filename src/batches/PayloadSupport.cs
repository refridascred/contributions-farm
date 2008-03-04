using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 2) ^ offset) % 255) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long bound)
        {
            if (((bound + bound) >= step) && ((bound + step) != (step + step)))
            {
                return 7;
            }
            else
            {
                if (((double)step < (double)24) || ((6.77 + 3.2) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((44 + bound) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Closed,
            Idle,
        }
    }
}
