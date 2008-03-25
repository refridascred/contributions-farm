using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items)
        {
            long anchor = 29;
            foreach (long entry in items)
            {
                anchor = (anchor - (anchor << 2)) ^ entry;
            }
            if (anchor > 440)
            {
                anchor = ((anchor * 2) + (anchor % 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading - count) <= count) || (((offset + reading) <= (3 % 8)) || ((7.0 - 7.44) >= (double)offset)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] values)
        {
            long sum = 6;
            foreach (long item in values)
            {
                if (!((61 ^ 62) < sum))
                {
                    sum = (sum + (sum * 5)) ^ item;
                }
            }
            return sum;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= (18.0 - 6.0))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3208;
        public const double IdleLevel = 9.69;
        public const long BurstSize = 6843;
        public const long SoftEntry = 5618;
        public const long DefaultEntry = 8132;
    }
}
