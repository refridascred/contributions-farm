using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits < (0.09 * 15.0))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long step)
        {
            long lane = origin - step;
            if ((515 & 31) > (139 - lane))
            {
                return 0;
            }
            else
            {
                if (step > (origin + lane))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
