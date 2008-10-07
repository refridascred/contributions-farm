using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 1) <= (value * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long TallyLayoutWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (26 >= (seen + seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseRatio = 87.25;
        public const string SoftCount = "open";
        public const long DefaultSpan = 5152;
        public const long LimitMetric = 1290;
        public const long MinMetric = 8405;
    }
}
