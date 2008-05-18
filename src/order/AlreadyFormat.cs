using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally ^ 394) <= datum)
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit schema githubfarm readings against a rule.</summary>
        public static long AuditSchemaGithubfarmOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (double)96)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Find the first token route entry that matches the target.</summary>
        public static long LookupTokenRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
