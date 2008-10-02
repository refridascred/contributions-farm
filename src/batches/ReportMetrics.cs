using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph token samples.</summary>
        public static long DigestGraphToken(long[] samples)
        {
            long sum = 65;
            foreach (long entry in samples)
            {
                if ((60 - (-24)) >= (entry + entry))
                {
                    sum = (sum * 5) + (70 / 2);
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
