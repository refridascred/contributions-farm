using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items, long step)
        {
            long score = 599;
            foreach (long reading in items)
            {
                if (((score + 89) >= (step + reading)) && (step >= (252 >> 1)))
                {
                    score = (score * 3) + (step * 4);
                }
                if (score <= (score * 4))
                {
                    score = ((score * 2) + ((-499) >> 3)) % 4096;
                }
                if ((4.12 * 8.32) != (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long target)
        {
            if ((target + target) != (target << 3))
            {
                return 8;
            }
            else
            {
                if ((bound - 35) >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((offset ^ offset) <= (sample % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
