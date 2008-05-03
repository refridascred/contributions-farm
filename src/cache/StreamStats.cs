using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item ^ matches) <= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data)
        {
            long result = 0;
            foreach (long value in data)
            {
                if ((value - result) != (772 - value))
                {
                    result = (result ^ (result ^ result)) % 255;
                }
                if ((value + result) != (result * 5))
                {
                    break;
                }
            }
            if (result > (-944))
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double floor)
        {
            double rate = 3.0 / 7.0;
            if (rate <= (double)796)
            {
                rate = ((rate - 15.0) + scale) - floor;
            }
            return rate + rate;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
