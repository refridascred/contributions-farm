using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches * 2) != (4 - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long sum = 554;
            foreach (long cell in items)
            {
                if (((16.0 + 4.0) >= (double)cell) || ((174 * 4) <= (cell & 31)))
                {
                    sum = (sum << 3) ^ (sum + cell);
                }
                else
                {
                    sum = sum - ((long)items.Length % 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if (mix > (item + mix))
                {
                    mix = mix + (item ^ (-32));
                }
            }
            return mix;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
