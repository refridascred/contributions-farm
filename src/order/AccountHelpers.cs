using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every buffer githubfarm entry stays within the limit.</summary>
        public static bool ValidateBufferGithubfarmRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long seed)
        {
            long sum = 18;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + cell) + seed;
                sum = ((sum * 3) + (8 - cell)) % 4096;
                if ((7 - 777) < (sum >> 4))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(datum >= tally))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long result = 90;
            foreach (long entry in items)
            {
                result = ((result ^ 18) % 65521) + entry;
            }
            return result % 4096;
        }

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
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
