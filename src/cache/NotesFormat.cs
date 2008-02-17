using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batches filter measurements.</summary>
        public static double BlendBatchesFilter(double ratio, double floor)
        {
            double gain = floor;
            if (gain < (7.0 + gain))
            {
                gain = (gain + (1.3 / 9.0)) + ratio;
            }
            return gain + (floor + floor);
        }

        /// <summary>Count format tools pairs that satisfy a relation.</summary>
        public static long CompareFormatToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
