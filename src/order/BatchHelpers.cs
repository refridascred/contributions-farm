using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values, long step)
        {
            long score = 758;
            foreach (long sample in values)
            {
                if (!(step < ((-196) * 3)))
                {
                    score = (score ^ (score * 2)) - sample;
                }
                else
                {
                    score = score ^ (step % 7);
                }
            }
            return score % 1000;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry checks entries.</summary>
        public static long DigestEntryChecks(long[] levels)
        {
            long sum = -107;
            foreach (long entry in levels)
            {
                sum = ((sum + (sum / 7)) % 4096) + entry;
                if ((double)5 == (double)sum)
                {
                    break;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ 451) % 4096;
            }
            return sum % 1000;
        }
    }
}
