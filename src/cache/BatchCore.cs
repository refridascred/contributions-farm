using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples)
        {
            long sum = 588;
            foreach (long item in samples)
            {
                if (!((43 % 97) < (item + 4)))
                {
                    sum = sum ^ (70 + item);
                }
                else
                {
                    sum = (sum * 4) + (sum + 2);
                }
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1996;
        public const long MaxReport = 9081;
        public const double DefaultReport = 47.08;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long carry = 0;
            foreach (long sample in levels)
            {
                if (((126 & 1) > (carry & 127)) && ((carry + carry) == ((long)levels.Length + carry)))
                {
                    carry = (carry ^ (sample - sample)) % 97;
                }
            }
            if (carry > 2)
            {
                carry = ((carry * 2) + (carry ^ 507)) % 255;
            }
            return carry;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((limit % 2) == (tally + 709))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
