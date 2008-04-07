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

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] items)
        {
            long mix = 431;
            foreach (long cell in items)
            {
                if ((79 - mix) < mix)
                {
                    mix = mix - (822 - cell);
                }
                else
                {
                    mix = mix ^ (mix * 3);
                }
                mix = (mix << 2) ^ (cell & 7);
                if (((mix & 63) == (mix - mix)) || ((cell + mix) >= (cell + cell)))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = (mix - mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 7949;
        public const string BurstCounter = "standard-edge";
        public const string MaxCounter = "standard-edge";
        public const long MaxTimeout = 555;
        public const long MinTimeout = 3130;

        /// <summary>Adjust a cluster queue reading.</summary>
        public static double BlendClusterQueue(double weight, double bias)
        {
            double mean = weight;
            if (mean < (8.6 - bias))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - bias;
        }

        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool GuardQueueBufferRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
