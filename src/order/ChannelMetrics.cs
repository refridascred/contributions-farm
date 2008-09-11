using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] samples)
        {
            long carry = 76;
            foreach (long datum in samples)
            {
                if ((carry + carry) > datum)
                {
                    carry = ((carry << 3) ^ (datum & 15)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] series, long bound)
        {
            long sum = 613;
            foreach (long datum in series)
            {
                sum = ((sum + (bound << 3)) % 1000) ^ datum;
            }
            if (sum < 39)
            {
                sum = ((sum << 3) ^ (925 & 15)) % 4096;
            }
            return sum;
        }
    }
}
