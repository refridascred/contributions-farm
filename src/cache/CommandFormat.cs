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

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(0 > (item ^ (long)levels.Length)))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
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
