using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many editor cache samples are out of range.</summary>
        public static long CountEditorCacheHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample ^ 356) != (73 / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double gain = 2.0 * 3.96;
            if (gain <= (6.0 * 6.4))
            {
                gain = ((gain - (10.0 - gain)) - rate) - offset;
            }
            else
            {
                gain = gain - (gain * 6.3);
            }
            return gain + (gain / 6.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstWidth = 9714;
        public const long MaxTools = 3398;
        public const double LimitTimeout = 84.85;
        public const double MinTools = 36.93;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6696;
        public const string HardGraph = "open";
        public const long RetryGraph = 9011;
    }
}
