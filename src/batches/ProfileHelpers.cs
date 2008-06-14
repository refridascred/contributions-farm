using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (double)matches)
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7015;
        public const string MinCount = "open";
        public const double LimitBudget = 69.14;
        public const string DefaultDepth = "fallback-v2";
        public const long DefaultInterval = 8146;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultSpan = 64.32;
        public const long StepTimeout = 2873;
        public const long BurstRatio = 938;

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long bound)
        {
            long carry = 92;
            foreach (long sample in data)
            {
                if (((900 + sample) >= bound) && ((8 - sample) > (bound / 6)))
                {
                    carry = (carry ^ 56) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (174 >> 5)) % 1000;
                }
                if ((carry + carry) == (carry * 2))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((0.91 + 7.6) <= (double)hits)
                {
                    hits = ((hits + 1) ^ datum) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double drift = (offset + offset) / 5.0;
            return (drift + offset) + scale;
        }
    }
}
