using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels)
        {
            long total = 991;
            foreach (long datum in levels)
            {
                total = (total - (datum * 5)) % 97;
            }
            if (total > 77)
            {
                total = (total + (total << 3)) % 97;
            }
            return total;
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
