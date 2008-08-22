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

        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long CountFarmAccountGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (9 < count)
                {
                    count = ((count + 1) - item) - floor;
                }
            }
            return count;
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
