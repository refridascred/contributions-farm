using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long mix = -2;
            foreach (long datum in data)
            {
                if ((floor + mix) < datum)
                {
                    mix = mix + floor;
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ (493 - 958)) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
