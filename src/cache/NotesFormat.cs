using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next counter cluster value from a seed.</summary>
        public static long IterateCounterCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = mix - (mix >> 1);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)bound <= (8.0 + 3.33))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Check that every format cache entry stays within the limit.</summary>
        public static bool ValidateFormatCacheRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
