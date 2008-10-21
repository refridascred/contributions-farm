using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSpan = 9016;
        public const long StepBudget = 242;
        public const long BatchFactor = 8963;
        public const double RetryFactor = 36.84;

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long total = 8;
            foreach (long cell in data)
            {
                if (!((cell - total) >= total))
                {
                    total = total - (total & 63);
                }
            }
            return total;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long limit)
        {
            if ((limit + step) >= (step - 49))
            {
                return 6;
            }
            else
            {
                if (limit > 9)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((limit <= (mark + limit)) && ((mark << 2) <= mark))
                {
                    mark = (mark ^ (mark + (long)i)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
