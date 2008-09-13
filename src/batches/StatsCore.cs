using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleDepth = 7204;
        public const string SoftMetrics = "local-edge";
        public const string WindowInterval = "latest-v2";
        public const long WindowMetrics = 8653;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            New,
            Paused,
            Closed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double gain2 = bias + bias;
            if (gain2 >= (bias - gain2))
            {
                gain2 = (gain2 - gain2) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + 11.0) + (double)(long)i;
            }
            return gain2 - (double)891;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "cached";
        public const long BurstQueue = 9549;
        public const long LimitQueue = 7831;
        public const long RetryWidth = 1528;
        public const double SoftQueue = 25.8;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = (result * 2) + (origin - result);
                result = (result * 4) + ((long)i - 485);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
