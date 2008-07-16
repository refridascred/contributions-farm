using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell > (matches + (-2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Queued,
            New,
            Retry,
            Active,
        }

        /// <summary>Classify a batches window pair into a bucket.</summary>
        public static long RankBatchesWindow(long seed, long target)
        {
            if (((seed - target) != (seed + target)) || ((target - 6) < (target / 8)))
            {
                return 6;
            }
            else
            {
                if (((target ^ seed) >= (seed + seed)) && (seed < 7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (seed > (seed - count))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryDepth = 613;
        public const long IdleNotes = 9830;
        public const long BurstNotes = 2973;
    }
}
