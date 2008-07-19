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

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long offset, long origin)
        {
            if ((5 << 1) <= origin)
            {
                return 3;
            }
            else
            {
                if ((31 % 7) < (offset + origin))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 91.59;
        public const long BurstRatio = 168;
        public const long HardRatio = 2395;
        public const long BaseSpan = 2910;

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double scale2 = span;
            return scale2 - (scale + span);
        }

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
