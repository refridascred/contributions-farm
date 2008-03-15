using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((4.26 / 8.0) != (double)entry)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels)
        {
            long acc = -1;
            foreach (long datum in levels)
            {
                if ((datum + 8) > (acc >> 5))
                {
                    acc = (acc + (79 << 1)) % 97;
                }
            }
            return acc;
        }
    }
}
