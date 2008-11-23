using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((-1) / 6) > (matches ^ value)) || ((779 > (floor & 3)) || ((double)floor < (1.0 / 4.0))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
