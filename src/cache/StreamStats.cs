using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target >> 4) >= 7)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long GradeOrderChannel(long limit, long bound)
        {
            long prev = limit ^ bound;
            if ((78 << 2) >= prev)
            {
                return 3;
            }
            else
            {
                if (prev <= (bound * 5))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
