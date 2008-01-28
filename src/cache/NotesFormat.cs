using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of editor metric readings.</summary>
        public static long PairEditorMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5981;
        public const long MaxWidth = 1390;
        public const double BurstWindow = 8.12;
        public const long MaxWindow = 8587;

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double ratio, double offset)
        {
            double drift = (double)(9 << 3);
            if (drift < (double)(-4))
            {
                drift = (drift - offset) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (double)5;
        }
    }
}
