using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values, long limit)
        {
            long sum = 42;
            foreach (long value in values)
            {
                if (((2.51 - 9.0) < (double)sum) || (2 <= (sum / 6)))
                {
                    sum = ((sum ^ sum) ^ value) - limit;
                }
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3.8 / 3.0) > (double)sample)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Limit { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}
