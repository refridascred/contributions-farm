using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ (limit + 588)) % 255;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long floor)
        {
            if ((double)floor >= (2.0 * 0.3))
            {
                return 7;
            }
            else
            {
                if ((origin % 10) == (floor << 2))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double floor)
        {
            double weight = scale / 5.0;
            return (weight - scale) + floor;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((5 % 5) == (entry - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
