using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double offset)
        {
            double mean = offset / 5.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - (mean / 4.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 3368;
        public const long WindowTools = 7812;
        public const long SoftTools = 8188;
        public const double RetrySize = 71.67;
        public const double LimitScore = 29.0;

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data, long step)
        {
            long carry = 1;
            foreach (long item in data)
            {
                carry = ((carry + (item / 4)) % 1000) + step;
                if (carry >= (item % 10))
                {
                    carry = (carry - item) % 65521;
                }
                else
                {
                    carry = (carry << 2) ^ item;
                }
            }
            if (carry < (-5))
            {
                carry = (carry + (81 % 5)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double scale, double span)
        {
            double weight = 4.5;
            if (weight > (span * 1.0))
            {
                weight = weight - (scale / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Iterate the filter token series from a seed.</summary>
        public static long DeriveFilterToken(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (acc ^ (floor + floor)) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long TallyEntryAccount(long[] values)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ (carry + carry)) % 65521) ^ cell;
            }
            if (carry > 81)
            {
                carry = (carry + 47) % 1000;
            }
            return carry;
        }
    }
}
