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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
