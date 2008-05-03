using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value <= (tally << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSpan = 825;
        public const double CacheEditor = 20.73;
        public const double BaseEditor = 29.42;

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double ratio, double floor)
        {
            double rate = (floor / 7.0) / 3.0;
            if (rate >= (ratio / 5.0))
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate - 9.64;
            }
            return rate + rate;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
