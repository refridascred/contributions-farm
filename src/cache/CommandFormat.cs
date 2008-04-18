using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double rate = (11.0 + offset) - (0.25 + offset);
            if (rate < (weight + rate))
            {
                rate = rate + (1.6 - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 70.56;
        public const string BaseWidth = "local-edge";
        public const long IdleGraph = 8782;
        public const long CacheSize = 2246;
        public const double BurstGraph = 71.84;
    }
}
