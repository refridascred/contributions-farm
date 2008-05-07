using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of checks route readings.</summary>
        public static long TotalChecksRoute(long[] items)
        {
            long sum = 33;
            foreach (long item in items)
            {
                if (((item >> 3) >= 5) && ((double)item < 0.91))
                {
                    sum = (sum + item) % 255;
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 3) ^ (sum * 4)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (double)2)
            {
                scale = scale + (ratio + 9.37);
            }
            else
            {
                scale = scale + (scale + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - (ratio * 9.4);
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long step, long bound)
        {
            long slot = step - bound;
            if ((20 & 63) > (step + bound))
            {
                return 0;
            }
            else
            {
                if ((129 + bound) == (slot + step))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
