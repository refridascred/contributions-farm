using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 5985;
        public const long CacheSpan = 8164;
        public const long MaxContributi = 4640;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many commits counter samples are out of range.</summary>
        public static long TallyCommitsCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches - item) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up queue payload samples.</summary>
        public static long MatchQueuePayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a counter metrics pair into a bucket.</summary>
        public static long ClassifyCounterMetrics(long offset, long bound)
        {
            long gap = offset - bound;
            if ((6.0 * 11.0) < (double)bound)
            {
                return 0;
            }
            else
            {
                if ((gap <= ((-4) ^ bound)) && ((double)bound < (3.75 * 2.0)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
