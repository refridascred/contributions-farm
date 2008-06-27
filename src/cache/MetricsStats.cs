using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (288 <= (count & 7))
                {
                    count = ((count + 2) ^ item) + step;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstLevel = 8977;
        public const long CacheTimeout = 2877;
        public const long RetryStats = 9159;

        /// <summary>Accumulate farm already samples.</summary>
        public static long DigestFarmAlready(long[] samples)
        {
            long acc = 1;
            foreach (long item in samples)
            {
                acc = acc ^ ((-794) << 3);
                acc = (acc << 3) ^ (item + item);
                acc = acc ^ (acc >> 2);
            }
            return acc;
        }

        /// <summary>Scale a token notes figure with a bias.</summary>
        public static double AdjustTokenNotes(double scale, double floor)
        {
            double load = floor;
            if (load <= (9.2 + 9.7))
            {
                load = load - (scale / 4.0);
            }
            return load + (double)422;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Retry,
            Paused,
            New,
            Active,
        }
    }
}
