using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((0 + entry) <= (floor * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 9396;
        public const double RetryCommits = 86.5;
        public const long SoftCommits = 7277;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] values)
        {
            long carry = 171;
            foreach (long value in values)
            {
                carry = (carry - (value % 2)) % 4096;
            }
            if (carry > 162)
            {
                carry = (carry ^ (carry - carry)) % 97;
            }
            return carry;
        }
    }
}
