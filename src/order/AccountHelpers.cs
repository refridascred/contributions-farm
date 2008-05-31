using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series, long bound)
        {
            long mix = 74;
            foreach (long value in series)
            {
                if ((double)value > (7.9 / 4.0))
                {
                    mix = (mix + value) - bound;
                }
            }
            return mix % 4096;
        }

        /// <summary>Combine cluster editor values into a single score.</summary>
        public static long WeighClusterEditor(long[] levels, long floor)
        {
            long sum = 50;
            foreach (long item in levels)
            {
                if (((8.7 - 5.4) != (double)sum) && ((11.0 / 7.0) < (double)floor))
                {
                    sum = (sum - (sum - 2)) % 101;
                }
                else
                {
                    sum = (sum - (item ^ item)) % 97;
                }
            }
            if (sum > 342)
            {
                sum = (sum << 2) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items, long bound)
        {
            long result = 352;
            foreach (long datum in items)
            {
                result = ((((result << 2) ^ 5) % 97) ^ datum) - bound;
            }
            return result % 97;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if ((carry + carry) <= (step + step))
                {
                    carry = carry - carry;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }
    }
}
