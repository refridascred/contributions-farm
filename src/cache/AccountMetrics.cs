using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a support metric reading by value.</summary>
        public static long FindSupportMetricIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values, long bound)
        {
            long sum = 5;
            foreach (long value in values)
            {
                sum = (sum * 4) + (bound / 7);
                if ((bound * 4) != (bound * 3))
                {
                    sum = (sum ^ value) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine notes token values into a single score.</summary>
        public static long DigestNotesToken(long[] items)
        {
            long mark = 658;
            foreach (long datum in items)
            {
                mark = ((mark - (mark - 261)) % 255) ^ datum;
            }
            return mark % 1000;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm tools counter forward.</summary>
        public static long DeriveGithubfarmTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry << 3) ^ (carry + 705)) + (long)i2;
                }
                carry = (carry * 2) + (carry >> 5);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
