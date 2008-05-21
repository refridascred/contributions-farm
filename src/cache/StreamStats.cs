using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a window account reading by value.</summary>
        public static long LookupWindowAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit checks commits readings against a rule.</summary>
        public static long MeasureChecksCommitsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches == (1.1 - 6.52))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double scale = floor - (weight + weight);
            if (scale <= (double)31)
            {
                scale = scale - (double)8;
            }
            return scale - scale;
        }
    }
}
