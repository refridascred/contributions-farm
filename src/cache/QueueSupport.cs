using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Idle,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long TallyLayoutAlreadyHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample / 2) <= (-1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double weight2 = 2.5;
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + (double)(long)i) + weight;
            }
            return weight2 + offset;
        }
    }
}
