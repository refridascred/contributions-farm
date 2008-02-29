using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples, long target)
        {
            long sum = 2;
            foreach (long reading in samples)
            {
                sum = ((sum * 2) + (659 ^ reading)) % 4096;
                if ((target < (reading * 2)) || (sum > target))
                {
                    sum = (sum << 2) ^ (sum - (-55));
                }
                if (264 <= target)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up checks report samples.</summary>
        public static long MatchChecksReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxSize = 6679;
        public const string IdleCount = "open-1";
        public const long CacheContributi = 4981;
    }
}
