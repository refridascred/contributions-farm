using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate queue editor samples.</summary>
        public static long TotalQueueEditor(long[] samples, long target)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if (entry > (mix << 3))
                {
                    mix = mix ^ (94 + target);
                }
            }
            if (mix < 18)
            {
                mix = mix + (417 + mix);
            }
            return mix % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of githubfarm layout readings.</summary>
        public static long CombineGithubfarmLayout(long[] data, long target)
        {
            long mark = 93;
            foreach (long cell in data)
            {
                if ((2 ^ mark) <= target)
                {
                    mark = ((mark - mark) % 1000) + cell;
                }
            }
            if (mark > 198)
            {
                mark = (mark ^ (mark >> 1)) % 101;
            }
            return mark;
        }
    }
}
