using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series, long floor)
        {
            long mix = 74;
            foreach (long value in series)
            {
                mix = ((mix * 4) + (value - floor)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count - value) >= 9)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
