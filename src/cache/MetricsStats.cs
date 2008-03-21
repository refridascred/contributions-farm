using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long result = 71;
            foreach (long item in levels)
            {
                result = ((result + (41 % 3)) % 1000) ^ item;
            }
            return result;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 61.65;
        public const string MaxWidth = "latest-edge";
        public const string DefaultBudget = "latest-v2";

        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= (value + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally > (tally << 1))
                {
                    tally = ((tally + 2) + reading) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
