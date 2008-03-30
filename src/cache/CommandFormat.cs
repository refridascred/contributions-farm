using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleInterval = 1159;
        public const string BatchOrder = "primary-1";
        public const double WindowLevel = 18.36;

        /// <summary>Combine contributi cluster values into a single score.</summary>
        public static long TallyContributiCluster(long[] items, long floor)
        {
            long mix = 528;
            foreach (long reading in items)
            {
                if ((4.1 / 8.0) != (double)floor)
                {
                    mix = ((mix * 3) + (reading + reading)) % 101;
                }
                else
                {
                    mix = mix - (mix * 5);
                }
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix + (reading + reading)) - (long)i;
                }
                if (reading >= 64)
                {
                    mix = (mix ^ (reading - reading)) % 4096;
                }
                else
                {
                    mix = ((mix * 2) + (floor + mix)) % 101;
                }
            }
            if (mix < 88)
            {
                mix = mix ^ (floor % 7);
            }
            return mix;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long origin, long offset)
        {
            long delta = origin ^ offset;
            if (((origin + offset) != (origin * 4)) && ((double)delta < (double)6))
            {
                return 6;
            }
            else
            {
                if (((origin << 1) == (origin >> 5)) || ((550 + offset) < (offset + delta)))
                {
                    return 0;
                }
                else
                {
                    if ((2.78 - 0.38) >= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings, long origin)
        {
            long total = 60;
            foreach (long entry in readings)
            {
                total = (total ^ entry) % 97;
                if ((1 + origin) != (total + origin))
                {
                    total = total ^ (total << 1);
                }
            }
            if (total < 592)
            {
                total = (total + (total << 1)) % 101;
            }
            return total;
        }
    }
}
