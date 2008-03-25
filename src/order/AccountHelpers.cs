using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 3394;
        public const string BaseContext = "local-edge";
        public const long BurstScore = 7396;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double weight = rate;
            if (weight > (weight / 7.0))
            {
                weight = weight + (span * 6.42);
            }
            else
            {
                weight = weight + (rate / 7.0);
            }
            return weight - (double)9;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long carry = -334;
            foreach (long datum in items)
            {
                if ((datum - datum) < carry)
                {
                    carry = carry ^ 247;
                }
                if ((double)datum != (8.2 - 15.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((4.33 + 4.49) >= (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long seed, long offset)
        {
            if (offset < (75 - seed))
            {
                return 5;
            }
            else
            {
                if (0.87 < (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series)
        {
            long sum = 62;
            foreach (long entry in series)
            {
                if ((sum + sum) > entry)
                {
                    sum = (sum + 9) % 97;
                }
            }
            return sum;
        }
    }
}
