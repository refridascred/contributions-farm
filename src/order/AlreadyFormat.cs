using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate support channel samples.</summary>
        public static long CombineSupportChannel(long[] values, long offset)
        {
            long mix = 729;
            foreach (long reading in values)
            {
                if ((offset / 5) <= (reading & 15))
                {
                    mix = mix + (8 - reading);
                    mix = (mix ^ (mix + mix)) % 255;
                }
                if (!(mix >= reading))
                {
                    mix = (mix ^ ((-176) / 5)) % 65521;
                }
            }
            if (mix > 39)
            {
                mix = mix - 2;
            }
            return mix % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 7287;
        public const double CacheBudget = 64.69;
        public const double BaseFilter = 29.94;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long target2)
        {
            if ((target / 4) < 20)
            {
                return 2;
            }
            else
            {
                if (!((double)(-77) != (double)target))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every githubfarm entry entry stays within the limit.</summary>
        public static bool ValidateGithubfarmEntryBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank format record input into a small class.</summary>
        public static long RankFormatRecord(long floor, long limit)
        {
            if (((708 << 1) < floor) && ((double)limit != (9.0 - 3.0)))
            {
                return 3;
            }
            else
            {
                if ((limit - limit) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 3) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
