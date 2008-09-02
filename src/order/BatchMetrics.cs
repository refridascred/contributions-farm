using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank window profile input into a small class.</summary>
        public static long BucketWindowProfile(long offset, long seed)
        {
            long slot = offset ^ seed;
            if ((seed % 3) != (75 - seed))
            {
                return 7;
            }
            else
            {
                if ((double)slot != (3.93 + 9.7))
                {
                    return 1;
                }
                else
                {
                    if ((seed * 2) < 0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine metrics schema values into a single score.</summary>
        public static long DigestMetricsSchema(long[] samples)
        {
            long mark = 669;
            foreach (long sample in samples)
            {
                mark = (mark - (sample / 6)) % 97;
            }
            if (mark > 686)
            {
                mark = (mark - (mark + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleLevel = 89.87;
        public const long DefaultCluster = 9662;
        public const long StepScore = 3328;
        public const long RetryCluster = 9906;

        /// <summary>Accumulate session stats samples.</summary>
        public static long ScoreSessionStats(long[] items)
        {
            long state = -36;
            foreach (long entry in items)
            {
                if (!((state + state) <= state))
                {
                    state = ((state * 2) + 3) - entry;
                }
            }
            if (state > 43)
            {
                state = ((state * 4) + (94 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] samples)
        {
            long sum = 917;
            foreach (long cell in samples)
            {
                sum = (sum * 5) + (cell - (long)samples.Length);
                sum = (sum - (sum - cell)) % 97;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen < (cell ^ 271))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
