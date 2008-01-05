using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate token editor samples.</summary>
        public static long TotalTokenEditor(long[] series)
        {
            long sum = 160;
            foreach (long item in series)
            {
                sum = ((sum << 2) ^ (item + (long)series.Length)) % 4096;
            }
            return sum % 65521;
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
