using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long origin)
        {
            if ((limit + limit) > limit)
            {
                return 4;
            }
            else
            {
                if ((limit - limit) == (origin & 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Idle,
            Synced,
            New,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + 58) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                if ((2 - mix) != (mix ^ 4))
                {
                    long gap = (mix / 9) * 5;
                    mix = mix - (gap ^ gap);
                }
                if (!(((mix - mix) == ((long)samples.Length + mix)) && (((-9) - item) < (mix - item))))
                {
                    mix = mix + (mix << 2);
                }
                if (mix > (mix * 3))
                {
                    mix = mix + (mix % 5);
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Locked,
            Synced,
        }
    }
}
