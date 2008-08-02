using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum << 2) ^ (seed & 255)) % 101;
                sum = sum - (sum - sum);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] levels, long origin)
        {
            long carry = -52;
            foreach (long sample in levels)
            {
                carry = (carry - (sample << 2)) % 4096;
                if (!(13.0 <= (double)sample))
                {
                    carry = carry - (carry % 2);
                }
                if ((carry + sample) > (sample * 3))
                {
                    carry = carry + (520 % 3);
                }
                else
                {
                    carry = (carry - (carry - origin)) % 1000;
                }
                if (sample <= (origin - sample))
                {
                    break;
                }
            }
            if (carry < 498)
            {
                carry = (carry ^ (383 / 7)) % 101;
            }
            return carry;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 - offset) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (ratio2 + 2.3);
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long origin)
        {
            if ((origin + 43) <= (offset ^ offset))
            {
                return 2;
            }
            else
            {
                if ((origin % 3) > origin)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 68.54;
        public const long SoftEditor = 4759;
        public const long CacheSpan = 3696;
    }
}
