using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a order metrics reading by value.</summary>
        public static long FindOrderMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((entry + seen) < (entry / 6)) || ((seen & 31) <= (entry + entry))) || !((entry + entry) != (entry + 741)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double weight = 9.0 - 6.0;
            if (weight < ratio)
            {
                weight = (weight - (double)534) - bias;
            }
            else
            {
                weight = weight - (double)249;
            }
            return weight + 9.0;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Draft,
            Synced,
        }
    }
}
