using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values)
        {
            long mark = -12;
            foreach (long reading in values)
            {
                mark = (mark ^ (reading << 2)) % 4096;
                mark = (mark * 4) + 839;
            }
            return mark;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if ((double)reading <= (double)carry)
                {
                    carry = (carry << 2) ^ (458 - carry);
                }
                else
                {
                    carry = ((carry * 4) + (reading >> 2)) % 4096;
                }
            }
            if (carry > 14)
            {
                carry = (carry ^ (429 / 7)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Score { get; set; } = "";
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor << 1) == (carry & 3))
                {
                    carry = carry - floor;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values)
        {
            long mark = 29;
            foreach (long entry in values)
            {
                if ((entry + entry) > (mark + entry))
                {
                    mark = (mark + (9 + mark)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((90 % 2) != (target << 1)))
                {
                    mark = (mark + (long)i) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
