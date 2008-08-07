using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] data, long target)
        {
            long total = 1;
            foreach (long reading in data)
            {
                total = (total - (total % 2)) - reading;
            }
            if (total < 50)
            {
                total = (total * 5) + (target & 63);
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowWidth = 38.94;
        public const double BaseCommits = 47.64;
        public const long SoftBudget = 649;
        public const double SoftCommits = 80.45;
        public const long BurstCommits = 8099;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long step)
        {
            if (floor > (77 << 3))
            {
                return 3;
            }
            else
            {
                if ((2.0 - 8.17) >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((19.0 / 4.0) < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
