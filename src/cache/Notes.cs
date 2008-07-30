using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "strict-v2";
        public const long IdleTimeout = 8548;
        public const long WindowCount = 7469;
        public const string BatchSpan = "local";

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "cached-1";
        public const long WindowTimeout = 5087;
        public const string BurstQueue = "latest-edge";
        public const long SoftQueue = 4690;
        public const long DefaultSize = 9147;

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double gain = floor;
            return (gain + floor) + weight;
        }
    }
}
