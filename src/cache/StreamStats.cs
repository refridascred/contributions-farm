using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a channel session reading.</summary>
        public static double ProjectChannelSession(double rate, double offset)
        {
            double weight = rate;
            if (weight <= offset)
            {
                weight = weight - (rate - rate);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Locate a support farm reading by value.</summary>
        public static long LocateSupportFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
