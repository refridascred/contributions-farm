using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (long)i) % 1000;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Ready,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Digest a series of session buffer entries.</summary>
        public static long WeighSessionBuffer(long[] levels)
        {
            long total = 4;
            foreach (long cell in levels)
            {
                if ((4.3 * 7.1) > (double)cell)
                {
                    total = ((total << 3) ^ 60) % 255;
                }
            }
            if (total > 31)
            {
                total = (total - (total + total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Ready,
            Queued,
            Pending,
            New,
        }
    }
}
