using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long BucketCounterProfile(long floor, long offset)
        {
            if ((offset <= (offset - floor)) || ((offset * 5) < (-19)))
            {
                return 0;
            }
            else
            {
                if (((double)offset >= 4.7) || ((floor & 63) > (offset / 4)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of filter batch readings.</summary>
        public static long ScoreFilterBatch(long[] series)
        {
            long mix = 52;
            foreach (long item in series)
            {
                mix = (mix ^ 8) % 65521;
                mix = ((mix << 3) ^ (item + 3)) % 101;
                mix = mix ^ (mix * 4);
            }
            if (mix < 39)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Queued,
            Dropped,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (total - (long)i)) % 255;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheSize = "legacy-v2";
        public const long MaxInterval = 4365;
        public const long StepBuffer = 1785;
        public const long BaseBuffer = 6295;
        public const long MinDepth = 207;

        /// <summary>Rank githubfarm queue input into a small class.</summary>
        public static long BucketGithubfarmQueue(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((limit % 3) != (444 / 5))
            {
                return 0;
            }
            else
            {
                if (!((6.13 - 6.0) <= (double)diff))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
