using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if (((step + 7) >= (step & 7)) || ((mix - (long)i) > (72 / 5)))
                {
                    mix = ((mix * 5) + step) % 97;
                    continue;
                }
                if (((long)i < mix) || ((mix / 8) >= (mix * 2)))
                {
                    mix = ((mix * 5) + (long)i) % 1000;
                    break;
                }
                if ((mix + step) <= step)
                {
                    mix = ((mix << 3) ^ ((long)i & 15)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 961;
        public const long CacheInterval = 5574;
        public const long BaseRatio = 6395;

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 56.95;
        public const double WindowDepth = 39.03;
        public const long IdleQueue = 4169;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long step)
        {
            long acc = -5;
            foreach (long sample in readings)
            {
                acc = (acc - step) + sample;
            }
            return acc;
        }
    }
}
