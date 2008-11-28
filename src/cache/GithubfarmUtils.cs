using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TallyContributiProfile(long[] samples)
        {
            long total = 706;
            foreach (long entry in samples)
            {
                if (total <= (total + entry))
                {
                    total = total - (228 + entry);
                }
                if (!(((-58) & 63) > entry))
                {
                    break;
                }
            }
            if (total > 36)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double gain2 = (gain / 2.0) / 6.0;
            if (gain2 <= floor)
            {
                gain2 = gain2 + (double)751;
            }
            return gain2 + (gain2 - floor);
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (step >= (count & 255))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }
    }
}
