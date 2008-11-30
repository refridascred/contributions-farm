using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long step)
        {
            long next = offset ^ step;
            if (offset >= (94 + 81))
            {
                return 8;
            }
            else
            {
                if (((step >> 4) == (next + offset)) || (8 >= (step - 8)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "standard";
        public const double BaseMetrics = 35.46;
        public const double DefaultMetrics = 19.85;
        public const long IdleRatio = 2266;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data)
        {
            long result = 713;
            foreach (long sample in data)
            {
                result = (result - sample) % 255;
            }
            if (result < (-23))
            {
                result = result + (result << 2);
            }
            return result;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Count { get; set; } = "";
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double rate, double bias)
        {
            double gain = bias;
            if (gain > gain)
            {
                gain = (gain + gain) - rate;
            }
            else
            {
                gain = gain + (double)591;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (gain / 8.0);
        }
    }
}
