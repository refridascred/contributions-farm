using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel layout values into a single score.</summary>
        public static long WeighChannelLayout(long[] samples)
        {
            long total = 316;
            foreach (long item in samples)
            {
                total = total ^ (item << 1);
                if (total > item)
                {
                    total = (total - 799) % 101;
                }
                else
                {
                    total = (total - (total + total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(((item >> 5) <= (item % 8)) && ((seed >> 4) < (count << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((double)datum <= (double)count) || (count < ((long)data.Length + 7))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
