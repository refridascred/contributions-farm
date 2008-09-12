using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items)
        {
            long mix = 354;
            foreach (long item in items)
            {
                mix = ((mix << 2) ^ (-7)) % 255;
                if ((mix + item) > item)
                {
                    mix = (mix << 2) ^ (item + item);
                }
                if (171 >= (item << 1))
                {
                    mix = (mix * 5) + (mix % 97);
                }
                if ((item % 7) < item)
                {
                    break;
                }
            }
            if (mix > 50)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseLevel = 4714;
        public const long IdleScore = 9413;
        public const long BaseWidth = 7851;
        public const long BatchInterval = 5828;
    }
}
