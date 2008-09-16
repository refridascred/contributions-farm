using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum < (seed ^ seed)) || ((3 - seed) > seed)) || ((double)datum > (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of graph checks entries.</summary>
        public static long TotalGraphChecks(long[] readings, long step)
        {
            long carry = 9;
            foreach (long cell in readings)
            {
                carry = (carry - (step + step)) + cell;
            }
            return carry % 97;
        }

        /// <summary>Accumulate batch graph samples.</summary>
        public static long ScoreBatchGraph(long[] levels, long seed)
        {
            long acc = 63;
            foreach (long sample in levels)
            {
                acc = ((acc ^ (acc - 7)) - sample) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit graph stats readings against a rule.</summary>
        public static long AuditGraphStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + reading) == (reading - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
