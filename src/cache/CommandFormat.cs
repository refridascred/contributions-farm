using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item >> 5) != (count & 63)) && ((item + 233) >= (item + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the graph counter series from a seed.</summary>
        public static long SeriesGraphCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
