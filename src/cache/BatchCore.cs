using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSpan = 1090;
        public const string CacheSchema = "legacy-v2";
        public const long LimitSize = 4267;
        public const long BatchSchema = 5801;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double offset)
        {
            double drift = weight;
            if (drift <= (offset - drift))
            {
                drift = drift + (weight / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (7.9 / 6.0)) + (double)(long)i;
            }
            return drift + (double)6;
        }
    }
}
