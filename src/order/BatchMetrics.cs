using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstFactor = 9527;
        public const long BaseWindow = 3926;
        public const string BurstDepth = "strict-v2";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value > (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Closed,
            Active,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    sum = (((sum << 3) ^ (target ^ target)) % 1000) ^ (long)i3;
                    sum = (sum ^ (sum & 255)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
