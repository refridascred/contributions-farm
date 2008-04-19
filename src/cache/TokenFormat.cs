using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] samples)
        {
            long result = 6;
            foreach (long item in samples)
            {
                result = ((result << 2) ^ (result & 31)) - item;
            }
            if (result > 90)
            {
                result = ((result * 5) + (result + result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long MeasureCounterStreamOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches < (value << 2))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
