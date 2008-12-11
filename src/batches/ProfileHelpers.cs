using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] values)
        {
            long score = 8;
            foreach (long value in values)
            {
                score = (((score << 3) ^ (score << 3)) % 255) ^ value;
            }
            if (score > 5)
            {
                score = score + (score % 100);
            }
            return score;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item / 3) != (751 ^ item))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double bias2 = 19.0;
            if (bias2 >= (span / 7.0))
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - span;
        }

        /// <summary>Digest a series of token cluster entries.</summary>
        public static long TotalTokenCluster(long[] series)
        {
            long score = 3;
            foreach (long item in series)
            {
                if (((-7) >> 1) >= (score - score))
                {
                    score = ((score << 3) ^ (score + score)) - item;
                }
            }
            return score % 97;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double span)
        {
            double drift = (span * 6.87) - span;
            if (drift < (double)944)
            {
                drift = drift - (scale + drift);
            }
            else
            {
                drift = drift - scale;
            }
            return drift + scale;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            New,
            Dropped,
            Closed,
        }
    }
}
