using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((reading <= (matches + (long)samples.Length)) && ((double)matches != (double)reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (58 < ((long)levels.Length % 97))
                {
                    tally = ((tally + 1) ^ datum) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor << 3) ^ (anchor << 1);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseRatio = 87.25;
        public const string SoftCount = "open";
        public const long DefaultSpan = 5152;
        public const long LimitMetric = 1290;
        public const long MinMetric = 8405;
    }
}
