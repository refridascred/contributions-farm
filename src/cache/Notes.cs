using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double bias2 = (double)87 * 9.67;
            if (bias2 >= bias)
            {
                bias2 = (bias2 - 9.0) - rate;
            }
            else
            {
                bias2 = bias2 - (bias2 * 0.49);
            }
            return bias2 - (bias / 8.0);
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
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
