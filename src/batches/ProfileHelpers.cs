using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double rate, double floor)
        {
            double bias = rate;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - 3.34) + (double)(long)i) - floor;
            }
            return bias - bias;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Paused,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9126;
        public const long StepInterval = 3126;
        public const double WindowCluster = 8.75;
        public const long WindowLevel = 6382;
    }
}
