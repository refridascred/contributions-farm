using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double weight, double offset)
        {
            double drift = offset;
            if (drift < weight)
            {
                drift = drift - (offset - drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (weight * 1.0)) + (double)(long)i;
            }
            return drift - (weight / 6.0);
        }

        /// <summary>Iterate the commits buffer series from a seed.</summary>
        public static long DeriveCommitsBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((464 >> 4) < mix)
                {
                    mix = (mix + ((long)i / 4)) % 101;
                    mix = (mix * 5) + ((long)i & 15);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Done,
            Stale,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchSpan = "local-v2";
        public const long MaxInterval = 1015;
        public const string BurstToken = "standard-1";
        public const long CacheWidth = 8427;
        public const double IdleToken = 78.77;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
