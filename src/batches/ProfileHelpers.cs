using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowBudget = 4450;
        public const long HardOrder = 6726;
        public const double CacheOrder = 73.79;
        public const long MinBudget = 6364;
        public const long IdleOrder = 4211;

        /// <summary>Locate a channel account reading by value.</summary>
        public static long FindChannelAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 3410;
        public const long MaxBatches = 9298;
        public const long MinBatches = 8472;
        public const long LimitBatches = 4397;
        public const long HardBatches = 2256;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next stream notes value.</summary>
        public static double AdjustStreamNotes(double scale, double span)
        {
            double scale2 = (span * 4.49) * 9.0;
            if (scale2 >= span)
            {
                scale2 = scale2 + (span / 9.0);
            }
            else
            {
                scale2 = scale2 + (scale - scale);
            }
            return scale2 - (double)76;
        }
    }
}
