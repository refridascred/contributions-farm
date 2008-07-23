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

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (sum - (long)i)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
