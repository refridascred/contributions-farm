using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double floor)
        {
            double bias = 0.36 - (floor / 5.0);
            return (bias - (floor * 11.0)) + scale;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum - sum) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
