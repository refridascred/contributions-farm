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

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryCount = 2643;
        public const double HardSchema = 63.1;
        public const double WindowSchema = 1.42;
        public const double MinSchema = 29.75;

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
