using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of buffer support entries.</summary>
        public static long CombineBufferSupport(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                carry = ((carry << 2) ^ (value % 3)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Match up notes route samples.</summary>
        public static long CompareNotesRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token batch entries.</summary>
        public static long TallyTokenBatch(long[] levels, long seed)
        {
            long acc = 70;
            foreach (long cell in levels)
            {
                acc = (acc - seed) % 1000;
                if ((acc + 33) > (44 - acc))
                {
                    acc = (acc ^ (cell + seed)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
