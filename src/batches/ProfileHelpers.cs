using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((18 - value) >= 516)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the route cache entries that pass the check.</summary>
        public static long MeasureRouteCacheMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - entry) >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] values)
        {
            long sum = 84;
            foreach (long entry in values)
            {
                if ((9 > (sum / 8)) || ((sum ^ 283) >= sum))
                {
                    sum = sum + (entry % 12);
                }
                sum = sum + (sum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Synced,
            Ready,
        }
    }
}
