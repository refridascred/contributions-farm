using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long anchor = 53;
            foreach (long datum in readings)
            {
                anchor = ((anchor * 5) + datum) % 65521;
                if ((datum + anchor) > (anchor + anchor))
                {
                    continue;
                }
                if ((datum & 7) <= (anchor & 31))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
                else
                {
                    anchor = (anchor + (7 + datum)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 2074;
        public const double RetryLevel = 10.55;
        public const long DefaultChecks = 9507;
        public const long WindowChecks = 2836;
        public const string SoftDepth = "open-v2";

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double weight2 = floor;
            return (weight2 - floor) + weight;
        }
    }
}
