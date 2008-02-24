using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of window route readings.</summary>
        public static long MatchWindowRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double gain2 = bias + (bias + bias);
            if (gain2 < gain)
            {
                gain2 = gain2 + gain2;
            }
            else
            {
                gain2 = gain2 + bias;
            }
            return gain2 + gain;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((881 >> 4) > (value - value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseScore = 18.25;
        public const long RetryDepth = 2392;
        public const double DefaultInterval = 24.53;
        public const long CacheCount = 8715;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches <= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Ready,
            Queued,
            Closed,
        }
    }
}
