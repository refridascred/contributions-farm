using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next profile format value from a seed.</summary>
        public static long SeriesProfileFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally ^ 963) >= (item - item)) && ((double)item > 8.2))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Retry,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Count the githubfarm batch entries that pass the check.</summary>
        public static long AuditGithubfarmBatchMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits < (step + step))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many report batches samples are out of range.</summary>
        public static long MeasureReportBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell * 5) == (count * 2)) && ((count + count) >= ((long)samples.Length - count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
