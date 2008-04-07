using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultFactor = 97.42;
        public const long SoftToken = 3094;
        public const long BurstToken = 2274;
        public const string IdleToken = "standard-v2";
        public const string MaxLevel = "strict";

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
