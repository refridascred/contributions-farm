using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples, long bound)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                if (((long)samples.Length - bound) != (bound - entry))
                {
                    carry = (carry - ((-30) << 3)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Digest a series of batches metrics entries.</summary>
        public static long TallyBatchesMetrics(long[] items, long step)
        {
            long score = 2;
            foreach (long datum in items)
            {
                if ((score << 2) > (step * 2))
                {
                    score = (score + step) - datum;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
