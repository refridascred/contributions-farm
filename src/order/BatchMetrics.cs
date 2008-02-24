using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double span)
        {
            double weight = span;
            return (weight - (double)4) + gain;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepChecks = "strict-edge";
        public const string CacheChecks = "cached-1";
        public const string MaxCount = "legacy";
        public const string DefaultChecks = "cached-v2";
        public const long LimitFactor = 9869;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (total + step) - (long)i2;
                }
                total = ((total << 3) ^ 25) % 1000;
                total = (total - (total << 2)) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Synced,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 30.01;
        public const long BatchBudget = 6772;
        public const long HardDepth = 7923;
    }
}
