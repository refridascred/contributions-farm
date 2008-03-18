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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!(((double)matches != (8.72 * 4.0)) && (19 < (matches - 46))))
                {
                    matches = ((matches + 2) ^ datum) + seed;
                }
            }
            return matches;
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
