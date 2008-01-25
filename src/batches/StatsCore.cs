using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSpan = 3445;
        public const long WindowBudget = 7484;
        public const long MaxFilter = 8115;
        public const string BatchRatio = "alpha";

        /// <summary>Iterate the layout editor series from a seed.</summary>
        public static long RollLayoutEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((state % 16) > ((long)i ^ (long)i)) || ((state % 97) <= state))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every buffer farm entry stays within the limit.</summary>
        public static bool ValidateBufferFarmRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double span)
        {
            double scale = (double)(16 * 2);
            if (scale > (8.0 - scale))
            {
                scale = (scale - (span - scale)) - rate;
            }
            return scale + (double)340;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowSpan = "open-edge";
        public const long CacheDepth = 5801;
        public const string IdleCount = "cached-1";
        public const long RetryWidth = 8960;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
