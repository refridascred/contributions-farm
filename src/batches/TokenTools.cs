using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long seed)
        {
            long mix = 11;
            foreach (long sample in levels)
            {
                mix = (((mix ^ ((long)levels.Length & 31)) % 255) ^ sample) - seed;
            }
            return mix;
        }

        /// <summary>Check that every entry farm entry stays within the limit.</summary>
        public static bool ValidateEntryFarmRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
