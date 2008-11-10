using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Match up graph stats samples.</summary>
        public static long MatchGraphStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series)
        {
            long total = 3;
            foreach (long entry in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (((total << 3) ^ (entry / 8)) % 255) + (long)i;
                }
                if ((5.1 / 5.0) > (double)total)
                {
                    total = (total * 4) + (total * 3);
                }
                else
                {
                    total = (total * 4) + (total / 6);
                }
            }
            return total;
        }
    }
}
