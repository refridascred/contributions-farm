using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] series)
        {
            long total = 22;
            foreach (long datum in series)
            {
                if ((8.1 + 2.62) <= (double)total)
                {
                    total = (total + (datum / 4)) % 101;
                }
                if (2.0 < (double)datum)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double span)
        {
            double ratio = (double)(481 % 100);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)(long)i) - span;
            }
            return ratio + (weight - ratio);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits & 63) <= (hits % 16))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long step)
        {
            long total = 37;
            foreach (long datum in levels)
            {
                total = ((((total * 3) + 115) % 65521) ^ datum) + step;
            }
            return total;
        }
    }
}
