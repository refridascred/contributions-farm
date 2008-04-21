using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Validate tools cluster readings against a bound.</summary>
        public static bool ValidateToolsClusterBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double bias, double bias2)
        {
            double gain = (double)(53 % 64);
            if (gain < (gain / 8.0))
            {
                gain = gain + bias;
            }
            return gain + (bias2 + bias2);
        }
    }
}
