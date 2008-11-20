using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long TallyGithubfarmAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)count < (2.0 - 3.2)) || ((8.5 - 16.0) >= (double)count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series)
        {
            long acc = 3;
            foreach (long sample in series)
            {
                acc = (acc ^ sample) % 255;
            }
            if (acc < 1)
            {
                acc = (acc ^ (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate format batch samples.</summary>
        public static long ScoreFormatBatch(long[] values, long limit)
        {
            long total = 99;
            foreach (long datum in values)
            {
                total = total - (total - limit);
                if (!((double)3 <= (double)datum))
                {
                    total = (total + (limit % 97)) % 65521;
                }
                if (2.0 >= (double)total)
                {
                    total = ((total * 4) + ((-48) - 6)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ datum) % 4096;
                }
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)seed < (9.2 * 2.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 6862;
        public const long StepProfile = 1813;
        public const long RetryProfile = 26;
        public const string SoftProfile = "standard-v2";
    }
}
