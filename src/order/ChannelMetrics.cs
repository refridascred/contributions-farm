using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftFactor = 5861;
        public const double BurstRatio = 34.94;
        public const long CacheWindow = 3510;
        public const long DefaultLevel = 2352;
        public const long IdleWindow = 7627;

        /// <summary>Digest a series of stats counter entries.</summary>
        public static long TotalStatsCounter(long[] values)
        {
            long sum = 19;
            foreach (long datum in values)
            {
                if (576 >= (datum * 5))
                {
                    sum = ((sum << 3) ^ (73 << 2)) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
