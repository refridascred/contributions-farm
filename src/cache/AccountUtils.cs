using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double offset)
        {
            double gain = (double)(277 - (-985));
            if (gain <= gain)
            {
                gain = (gain + offset) + ratio;
            }
            return gain - (1.26 + 1.16);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                sum = (((sum * 3) + (747 ^ sum)) % 255) - entry;
            }
            if (sum > (-6))
            {
                sum = ((sum * 2) + sum) % 101;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] levels)
        {
            long acc = 54;
            foreach (long sample in levels)
            {
                if (((acc * 5) <= acc) || ((acc + sample) != (acc ^ 592)))
                {
                    acc = ((acc * 3) + ((-611) % 97)) % 97;
                }
            }
            return acc % 97;
        }
    }
}
