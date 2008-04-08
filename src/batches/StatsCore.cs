using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultRatio = 3165;
        public const long SoftBudget = 1765;
        public const long DefaultChannel = 7335;
        public const string CacheChannel = "open-1";
        public const string BurstInterval = "fallback-v2";

        /// <summary>Classify a command farm pair into a bucket.</summary>
        public static long SortCommandFarm(long step, long seed)
        {
            long slot = step ^ seed;
            if (((slot >> 4) > (slot + seed)) || ((step + seed) <= (seed * 4)))
            {
                return 2;
            }
            else
            {
                if ((8.4 / 3.0) <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((6.95 + 1.82) > (double)tally)
                {
                    tally = ((tally + 3) + reading) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }
    }
}
