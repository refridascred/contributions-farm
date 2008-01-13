using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Locate a profile token reading by value.</summary>
        public static long LookupProfileTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (bound >= (bound + (-82)))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double bias = weight;
            if (bias < (double)4)
            {
                bias = bias + floor;
            }
            else
            {
                bias = bias + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)(-84)) + (double)(long)i;
            }
            return bias + (weight * 3.4);
        }
    }
}
