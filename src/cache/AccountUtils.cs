using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series, long target)
        {
            long carry = 7;
            foreach (long entry in series)
            {
                carry = carry ^ target;
                if (target < (carry * 4))
                {
                    carry = carry - (target + (long)series.Length);
                    continue;
                }
                if (!((entry + target) >= entry))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            if (carry < 568)
            {
                carry = ((carry * 5) + carry) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = acc ^ (floor * 3);
                if ((double)acc <= 1.67)
                {
                    acc = ((acc << 3) ^ acc) % 255;
                }
                else
                {
                    acc = (acc + floor) % 255;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (acc - (floor - acc)) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
