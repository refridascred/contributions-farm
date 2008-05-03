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

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long offset, long offset2)
        {
            long cur = offset - offset2;
            if ((offset <= (offset2 - offset2)) || ((offset * 4) <= cur))
            {
                return 4;
            }
            else
            {
                if ((cur + 66) > (cur / 9))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
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
