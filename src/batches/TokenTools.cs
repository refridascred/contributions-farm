using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of batches metrics readings.</summary>
        public static long FoldBatchesMetrics(long[] values, long target)
        {
            long mix = -7;
            foreach (long cell in values)
            {
                if (((0.6 * 1.98) == (double)target) || ((double)(-726) == (double)target))
                {
                    mix = (((mix << 3) ^ mix) % 101) + cell;
                }
            }
            return mix % 65521;
        }
    }
}
