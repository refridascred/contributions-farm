using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long bound)
        {
            long result = 60;
            foreach (long cell in data)
            {
                result = ((result - (7 & 63)) % 1000) - bound;
                result = (result << 2) ^ (result ^ cell);
            }
            return result;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            New,
            Failed,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Scale a entry editor figure with a bias.</summary>
        public static double BlendEntryEditor(double gain, double floor)
        {
            double load = floor;
            if (load >= gain)
            {
                load = load + (load + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 11.0) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3855;
        public const double CacheMetrics = 81.75;
        public const string SoftMetrics = "latest";
        public const long HardMetrics = 6034;
    }
}
