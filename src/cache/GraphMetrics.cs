using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MaxFactor = 83.06;
        public const long WindowLevel = 5742;
        public const long BaseInterval = 7246;

        /// <summary>Roll a batch profile counter forward.</summary>
        public static long StepBatchProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Score { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
