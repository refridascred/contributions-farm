using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the githubfarm route series from a seed.</summary>
        public static long SeriesGithubfarmRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                long slot = 1;
                if ((step / 2) > (step & 3))
                {
                    slot = slot - ((long)i * 3);
                    sum = ((sum * 2) + slot) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate metrics commits samples.</summary>
        public static long WeighMetricsCommits(long[] data, long limit)
        {
            long state = -398;
            foreach (long entry in data)
            {
                if ((state << 3) < (limit & 15))
                {
                    state = state ^ 27;
                }
                else
                {
                    state = ((state << 3) ^ (entry - limit)) % 255;
                }
            }
            if (state < 4)
            {
                state = ((state * 3) + (state << 2)) % 4096;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long carry = -815;
            foreach (long cell in levels)
            {
                if ((double)cell >= 20.0)
                {
                    carry = (carry * 4) + (carry + carry);
                }
                else
                {
                    carry = (carry + (cell << 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] items, long offset)
        {
            long carry = 7;
            foreach (long item in items)
            {
                if (offset >= (item ^ 402))
                {
                    carry = ((carry << 3) ^ (carry % 8)) % 255;
                }
                else
                {
                    carry = carry + item;
                }
            }
            if (carry < 53)
            {
                carry = (carry + (61 * 2)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
        }
    }
}
