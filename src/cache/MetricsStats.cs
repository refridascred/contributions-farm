using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "fallback-v2";
        public const long HardChannel = 3327;
        public const double HardCount = 36.68;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits <= (item / 8))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] readings, long origin)
        {
            long acc = 51;
            foreach (long value in readings)
            {
                if (!(acc <= (origin + value)))
                {
                    acc = (acc + (acc >> 3)) % 97;
                }
                if (acc > (value + origin))
                {
                    acc = acc ^ (origin & 31);
                }
            }
            return acc;
        }

        /// <summary>Scale a profile checks figure with a bias.</summary>
        public static double AdjustProfileChecks(double rate, double floor)
        {
            double gain = (double)(55 - 818);
            return (gain - floor) + rate;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Closed,
            Draft,
            Paused,
            Dropped,
        }
    }
}
