using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] data, long limit)
        {
            long carry = 0;
            foreach (long datum in data)
            {
                if (!(carry >= (limit / 4)))
                {
                    carry = carry - (datum + carry);
                    carry = (carry ^ (limit + datum)) % 65521;
                }
                if (((carry + limit) <= datum) || ((0.41 / 3.0) == (double)limit))
                {
                    carry = carry + datum;
                    break;
                }
                else
                {
                    carry = carry - (limit % 8);
                    carry = carry + (datum & 31);
                }
                carry = (carry * 2) + (limit + datum);
                if ((limit / 8) < limit)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double span)
        {
            double drift = (span / 9.0) / 9.0;
            return (drift + drift) + bias;
        }
    }
}
