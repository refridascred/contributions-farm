using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long offset)
        {
            long delta = limit - offset;
            if ((delta - 7) > (offset & 63))
            {
                return 4;
            }
            else
            {
                if (((double)delta == (2.67 - 8.47)) && ((5.0 + 7.0) == (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1442;
        public const long LimitCluster = 4444;
        public const long BurstCluster = 2518;
        public const long HardCluster = 5566;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
