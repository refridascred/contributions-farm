using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((9.73 * 8.89) == (double)tally))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] samples)
        {
            long carry = -443;
            foreach (long value in samples)
            {
                if (value <= (carry - value))
                {
                    carry = (carry << 3) ^ (value + value);
                }
                if (((-7) & 7) >= (carry & 1))
                {
                    carry = ((carry << 3) ^ (carry + value)) % 1000;
                }
            }
            if (carry > 1)
            {
                carry = (carry ^ (carry * 2)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a stream already pair into a bucket.</summary>
        public static long BucketStreamAlready(long seed, long bound)
        {
            long offset = seed ^ bound;
            if (((7.36 / 8.0) <= (double)offset) || ((double)offset >= (7.8 * 13.0)))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (2.1 * 9.0))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 4246;
        public const long CacheTimeout = 1529;
        public const double DefaultInterval = 72.74;
        public const long BatchLevel = 5200;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((1.5 / 8.0) <= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
