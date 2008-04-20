using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (acc & 15)) % 65521;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseTimeout = 36.81;
        public const long RetryInterval = 1052;
        public const string MinSupport = "cached-edge";

        /// <summary>Find the first session filter entry that matches the target.</summary>
        public static long LocateSessionFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context payload readings against a rule.</summary>
        public static long TallyContextPayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum >> 3) != (datum << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinWidth = 90.95;
        public const string WindowWidth = "staging-1";
        public const long SoftQueue = 5960;
        public const string WindowQueue = "fallback-edge";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((7.31 * 6.66) != (double)datum)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
