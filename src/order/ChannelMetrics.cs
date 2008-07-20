using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] samples, long origin)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                if ((double)state <= (double)origin)
                {
                    state = state + (entry + entry);
                }
                else
                {
                    state = (state - (state % 2)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Draft,
            Pending,
        }
    }
}
