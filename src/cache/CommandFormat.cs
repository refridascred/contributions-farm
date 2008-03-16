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

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 1829;
        public const double DefaultStats = 35.36;
        public const long DefaultCount = 8338;
    }
}
