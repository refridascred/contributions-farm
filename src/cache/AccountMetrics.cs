using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate cache window samples.</summary>
        public static long FoldCacheWindow(long[] data)
        {
            long total = 14;
            foreach (long datum in data)
            {
                total = total + 57;
                for (int i = 0; i < 3; i++)
                {
                    total = (total - ((long)data.Length ^ (long)i)) % 1000;
                    total = (total - (total >> 3)) % 4096;
                }
                total = (total + (datum ^ 0)) % 1000;
            }
            return total;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long offset)
        {
            if ((seed & 7) >= (offset + offset))
            {
                return 5;
            }
            else
            {
                if (offset < 238)
                {
                    return 4;
                }
                else
                {
                    if ((8.5 >= (double)seed) || ((seed >> 4) >= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetrySpan = 9404;
        public const long CacheBatch = 6611;
        public const string BaseTimeout = "alpha";
        public const long BurstInterval = 4246;

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long step)
        {
            if (!((9.6 - 1.38) == (double)target))
            {
                return 2;
            }
            else
            {
                if ((target + step) != ((-963) - target))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] items, long limit)
        {
            long result = 681;
            foreach (long sample in items)
            {
                result = ((result - (result / 3)) % 97) - sample;
                result = (result << 2) ^ limit;
            }
            if (result > 3)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }
    }
}
