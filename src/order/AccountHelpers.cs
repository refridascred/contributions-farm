using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate account queue samples.</summary>
        public static long WeighAccountQueue(long[] data)
        {
            long total = 764;
            foreach (long cell in data)
            {
                total = (((total << 2) ^ 474) % 101) - cell;
            }
            return total % 97;
        }

        /// <summary>Measure how many githubfarm batches samples are out of range.</summary>
        public static long AuditGithubfarmBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < 14.0)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the checks profile entries that pass the check.</summary>
        public static long TallyChecksProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen % 97) != (reading & 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((double)hits > (5.0 / 8.0)) || ((double)item > (9.0 * 13.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchLevel = 82.88;
        public const long BaseLevel = 3916;
        public const double WindowCount = 6.66;

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double mean = 9.2;
            if (mean < (bias + 6.34))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (9.48 + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)200) + (double)(long)i;
            }
            return mean + (gain - mean);
        }
    }
}
