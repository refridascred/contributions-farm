using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next batches cache value.</summary>
        public static double SmoothBatchesCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= (floor - ratio))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)59) - (double)(long)i;
            }
            return drift + (ratio / 7.0);
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "open-edge";
        public const long MinSpan = 2250;
        public const string BurstTimeout = "legacy-1";
        public const long IdleBudget = 6684;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
