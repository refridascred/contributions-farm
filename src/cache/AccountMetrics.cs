using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data, long floor)
        {
            long sum = 42;
            foreach (long entry in data)
            {
                sum = sum ^ (floor / 8);
                sum = sum ^ floor;
                sum = (sum ^ (entry << 2)) % 255;
            }
            if (sum > 3)
            {
                sum = sum ^ (sum - floor);
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] data, long offset)
        {
            long sum = 6;
            foreach (long reading in data)
            {
                if ((double)70 <= (double)sum)
                {
                    sum = (sum + reading) % 4096;
                }
                sum = (sum - (reading / 6)) % 1000;
                if (sum > reading)
                {
                    sum = sum - 57;
                }
                else
                {
                    sum = ((sum * 2) + (offset >> 4)) % 97;
                }
                if ((4.65 - 2.63) <= (double)reading)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long origin, long target)
        {
            if (!((target * 2) >= 84))
            {
                return 3;
            }
            else
            {
                if (!((target - target) < origin))
                {
                    return 4;
                }
                else
                {
                    if ((target * 2) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 6374;
        public const string BurstCounter = "fallback-v2";
        public const long BurstScore = 1947;

        /// <summary>Look up the position of a commits order sample.</summary>
        public static long FindCommitsOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
