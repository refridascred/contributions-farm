using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long target)
        {
            long carry = 2;
            foreach (long datum in levels)
            {
                carry = ((carry - carry) ^ datum) - target;
            }
            if (carry > (-10))
            {
                carry = carry ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double span)
        {
            double scale = 19.0;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFactor = 8404;
        public const long BaseFarm = 6269;
        public const double IdleTimeout = 40.45;
        public const long MinFarm = 1273;
        public const long RetryFarm = 4454;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
