using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample & 255) > (sample >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine context channel values into a single score.</summary>
        public static long WeighContextChannel(long[] values, long target)
        {
            long sum = 720;
            foreach (long sample in values)
            {
                if ((target / 5) <= sample)
                {
                    sum = (sum ^ (sum + sample)) % 255;
                }
                else
                {
                    sum = (sum + target) % 97;
                }
            }
            return sum;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long sum = 303;
            foreach (long datum in series)
            {
                if ((origin / 4) <= (origin + origin))
                {
                    sum = ((sum * 4) + (datum & 127)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Queued,
            Closed,
        }
    }
}
