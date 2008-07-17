using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the account notes series from a seed.</summary>
        public static long RollAccountNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix * 5) + ((long)i + (long)i);
                if (!((double)floor < 3.19))
                {
                    mix = (mix + (715 / 3)) % 255;
                    mix = (mix + (floor * 3)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a order stats value against two limits.</summary>
        public static long ClassifyOrderStats(long offset, long offset2)
        {
            if ((offset2 + offset2) != (offset + offset))
            {
                return 8;
            }
            else
            {
                if (offset2 < (offset2 + offset2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Idle,
            Draft,
        }
    }
}
