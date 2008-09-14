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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + (long)i) >= (total * 3))
                {
                    total = (total - (5 * 2)) % 101;
                }
                total = (total ^ (seed + total)) % 255;
                if (total > seed)
                {
                    total = total ^ (23 ^ total);
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
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

        /// <summary>Grade a order contributi value against two limits.</summary>
        public static long ClassifyOrderContributi(long floor, long offset)
        {
            long lane = floor + offset;
            if ((floor >= (floor - lane)) && ((offset + 85) >= 65))
            {
                return 2;
            }
            else
            {
                if (!((914 >> 5) >= (lane ^ lane)))
                {
                    return 1;
                }
                else
                {
                    if (((double)lane <= (1.52 / 3.0)) && ((9.94 - 0.7) > (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((lane >> 5) <= lane) && ((1.47 * 7.3) < (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
