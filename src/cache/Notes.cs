using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "standard-v2";
        public const long HardInterval = 7466;
        public const string SoftPayload = "latest";

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double gain, double span)
        {
            double rate = gain;
            if (rate >= (double)134)
            {
                rate = (rate - rate) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long MeasureQueueStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((datum - hits) > hits) || ((datum + datum) > (hits << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
