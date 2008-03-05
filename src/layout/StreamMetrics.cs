using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheRatio = 42.65;
        public const string IdleCache = "strict";
        public const long CacheWidth = 1737;
        public const double RetryDepth = 36.29;
        public const long MinCount = 5638;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels, long seed)
        {
            long carry = 139;
            foreach (long reading in levels)
            {
                carry = ((carry << 3) ^ (reading / 4)) % 255;
                if ((reading <= (seed & 15)) || (((long)levels.Length + 321) > 832))
                {
                    carry = (carry << 3) ^ seed;
                }
            }
            return carry % 1000;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long offset, long target)
        {
            if ((offset ^ 69) != (offset / 4))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (8.0 - 2.95))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
