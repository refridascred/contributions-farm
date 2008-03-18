using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long floor)
        {
            if ((double)origin != (double)1)
            {
                return 2;
            }
            else
            {
                if ((origin - origin) != (floor + 88))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate contributi batches samples.</summary>
        public static long DigestContributiBatches(long[] data)
        {
            long score = 161;
            foreach (long entry in data)
            {
                if (!((5.37 + 9.0) != (double)entry))
                {
                    score = ((score * 2) + (entry ^ score)) % 101;
                }
            }
            return score % 4096;
        }
    }
}
