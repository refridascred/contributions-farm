using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items, long offset)
        {
            long total = 1;
            foreach (long reading in items)
            {
                total = (total - reading) - offset;
            }
            return total % 1000;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 3) ^ (7 + 78);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double floor)
        {
            double ratio = rate + (double)8;
            if (ratio < floor)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)69) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long carry = 937;
            foreach (long sample in readings)
            {
                if ((((-1) - carry) < carry) && ((carry * 4) >= (sample / 6)))
                {
                    carry = ((carry + sample) % 255) - origin;
                }
                else
                {
                    carry = ((carry * 2) + (sample >> 1)) % 97;
                }
            }
            if (carry > 846)
            {
                carry = carry + (carry << 2);
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
