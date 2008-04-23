using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "staging-1";
        public const long LimitStats = 9431;
        public const string SoftStats = "legacy-v2";

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double gain = 3.16;
            if (gain <= (6.0 - floor))
            {
                gain = (gain - (floor * 6.47)) + scale;
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 7.88) + (double)(long)i;
            }
            return gain + (double)(-7);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 9509;
        public const long HardWindow = 3420;
        public const long StepWindow = 2203;
        public const long LimitWindow = 7442;
    }
}
