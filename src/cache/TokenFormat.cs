using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 7) < (item & 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel stats entries.</summary>
        public static long WeighChannelStats(long[] data)
        {
            long result = -1;
            foreach (long value in data)
            {
                if ((value > (value + 686)) || ((result >> 2) <= (value & 255)))
                {
                    result = (result << 2) ^ value;
                }
            }
            if (result > 27)
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result % 1000;
        }
    }
}
