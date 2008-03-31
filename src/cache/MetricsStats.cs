using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardBudget = 1.85;
        public const long LimitFactor = 7525;
        public const string WindowSize = "legacy-v2";

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] series)
        {
            long mark = 34;
            foreach (long value in series)
            {
                if (!(((long)series.Length * 4) == (6 % 5)))
                {
                    mark = (mark + (value - value)) % 65521;
                }
                else
                {
                    mark = (mark + ((long)series.Length - 0)) % 1000;
                }
            }
            if (mark > 21)
            {
                mark = (mark - (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next githubfarm window value from a seed.</summary>
        public static long DeriveGithubfarmWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] readings, long target)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                carry = (carry - (0 - target)) % 97;
                if ((double)reading <= (1.4 * 3.0))
                {
                    carry = (carry + (target % 24)) % 101;
                }
                else
                {
                    carry = carry - (carry + target);
                }
            }
            if (carry > 35)
            {
                carry = carry + (target + carry);
            }
            return carry;
        }

        /// <summary>Rank route stream input into a small class.</summary>
        public static long GradeRouteStream(long target, long floor)
        {
            if (target <= (target * 3))
            {
                return 4;
            }
            else
            {
                if (floor <= (floor << 1))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
