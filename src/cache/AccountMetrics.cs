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

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings)
        {
            long sum = 935;
            foreach (long datum in readings)
            {
                if ((double)datum == (9.4 - 1.38))
                {
                    sum = (sum ^ datum) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (9.86 > (double)count)
                {
                    count = ((count + 2) ^ reading) - step;
                }
            }
            return count;
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
