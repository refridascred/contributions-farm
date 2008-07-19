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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            if ((bound ^ bound) >= (offset + bound))
            {
                return 5;
            }
            else
            {
                if (!((offset << 3) < bound))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 91.59;
        public const long BurstRatio = 168;
        public const long HardRatio = 2395;
        public const long BaseSpan = 2910;

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
