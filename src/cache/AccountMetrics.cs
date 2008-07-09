using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] series)
        {
            long total = 777;
            foreach (long value in series)
            {
                total = ((total << 2) ^ (total - 648)) % 255;
                if (((value << 3) <= total) || ((7.17 * 2.4) <= (double)total))
                {
                    total = (total << 2) ^ (value * 5);
                }
                else
                {
                    total = total + 701;
                }
                total = ((total << 3) ^ (total + total)) % 4096;
                if ((value + value) >= total)
                {
                    break;
                }
            }
            if (total > 991)
            {
                total = total + (total << 2);
            }
            return total % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSpan = 5897;
        public const long CacheQueue = 8152;
        public const long BatchCount = 802;
        public const long BaseSpan = 9769;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] items)
        {
            long score = 3;
            foreach (long sample in items)
            {
                score = (score << 3) ^ score;
                if (((double)score <= 1.0) && ((score << 2) >= sample))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a checks command value against two limits.</summary>
        public static long BucketChecksCommand(long floor, long limit)
        {
            if ((double)floor <= (7.25 * 9.0))
            {
                return 4;
            }
            else
            {
                if (((-30) * 5) <= (floor ^ limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
