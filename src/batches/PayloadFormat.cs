using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 9968;
        public const long DefaultBudget = 4300;
        public const long RetryCommits = 7848;
        public const string RetryScore = "cached-v2";

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double weight = offset - (6.2 - offset);
            return (weight - weight) + ratio;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits ^ datum) == (hits >> 2))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
