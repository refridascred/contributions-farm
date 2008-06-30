using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i - 2) <= ((long)i >> 2))
                {
                    mix = ((mix * 4) + (step >> 1)) % 1000;
                }
                if ((step * 2) == (mix % 5))
                {
                    mix = ((mix << 2) ^ 995) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value / 8) >= (floor - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long bound, long target)
        {
            if ((42 + target) >= (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((double)bound > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
