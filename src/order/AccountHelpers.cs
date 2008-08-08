using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
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

        /// <summary>Measure how many farm tools samples are out of range.</summary>
        public static long CountFarmToolsHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((target ^ seen) <= (seen + 72)) || !((entry - entry) < (seen - target)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
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
