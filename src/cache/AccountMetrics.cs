using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4313;
        public const string IdleSession = "stable";
        public const double MinSession = 62.02;

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

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
