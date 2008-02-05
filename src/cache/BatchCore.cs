using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((15.0 * 8.0) < (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster route entries that pass the check.</summary>
        public static long MeasureClusterRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((5.64 < (double)hits) && (((sample + sample) < 78) && ((7.9 - 5.13) >= (double)hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
