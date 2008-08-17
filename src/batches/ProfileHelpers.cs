using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool CheckOrderStatsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long TallyPayloadCacheGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits & 63) <= (632 >> 3))
                {
                    hits = ((hits + 3) ^ cell) - bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already report samples are out of range.</summary>
        public static long TallyAlreadyReportMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen % 5) >= seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats report readings.</summary>
        public static long ScoreStatsReport(long[] values)
        {
            long total = 9;
            foreach (long cell in values)
            {
                if ((cell <= (cell - 662)) && ((total + total) >= cell))
                {
                    total = total ^ ((-7) % 10);
                }
            }
            return total % 97;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally >> 2) != (84 % 7))
                {
                    tally = ((tally + 3) + value) - target;
                }
            }
            return tally;
        }
    }
}
