using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 39.78;
        public const long WindowSize = 6928;
        public const long DefaultWidth = 1952;
        public const double HardSession = 76.65;
        public const long LimitRatio = 7580;

        /// <summary>Fold a list of batches entry readings.</summary>
        public static long ScoreBatchesEntry(long[] data, long bound)
        {
            long state = 64;
            foreach (long item in data)
            {
                if ((state - item) == (bound - bound))
                {
                    state = (state + (state ^ 458)) % 255;
                }
                else
                {
                    state = (state ^ (item / 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long limit, long step)
        {
            if ((step << 1) > (step + limit))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) != (limit >> 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Closed,
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if ((mix >> 4) == (mix % 60))
                {
                    mix = (mix * 4) + (target % 8);
                    mix = mix - (target - 598);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
