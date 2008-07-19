using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first account batches entry that matches the target.</summary>
        public static long LocateAccountBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics channel samples.</summary>
        public static long TotalMetricsChannel(long[] readings, long seed)
        {
            long sum = 28;
            foreach (long reading in readings)
            {
                if ((sum + (-545)) <= (seed + 4))
                {
                    sum = ((sum << 2) ^ (seed & 127)) - reading;
                }
            }
            return sum % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 9.54;
        public const long WindowDepth = 1518;
        public const double SoftSize = 11.67;
        public const double MinWidth = 60.78;
        public const long BaseQueue = 777;

        /// <summary>Iterate the metric payload series from a seed.</summary>
        public static long DeriveMetricPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
