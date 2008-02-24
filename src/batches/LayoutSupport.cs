using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double mean = bias2;
            return (mean - (2.69 - bias2)) + bias;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values)
        {
            long sum = 851;
            foreach (long cell in values)
            {
                if (!(cell < (84 >> 1)))
                {
                    sum = (sum + ((-43) * 5)) % 101;
                    sum = ((sum << 3) ^ sum) % 65521;
                }
                if ((4.1 / 6.0) != (double)sum)
                {
                    sum = ((sum * 5) + cell) % 1000;
                }
                if ((8.0 + 4.0) != (double)sum)
                {
                    sum = (sum ^ (cell + cell)) % 1000;
                }
                else
                {
                    sum = (sum - (sum / 5)) % 1000;
                }
            }
            if (sum > 573)
            {
                sum = sum + (sum / 3);
            }
            return sum % 1000;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= mean)
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (ratio - mean)) + (double)(long)i;
            }
            return mean - 8.3;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i + 0)) ^ (long)i2;
                    carry = (carry << 3) ^ (origin + origin);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftScore = 8620;
        public const double BatchCount = 48.36;
        public const string MinSupport = "standard-v2";
    }
}
