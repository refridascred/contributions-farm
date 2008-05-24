using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 98.62;
        public const long BatchScore = 7048;
        public const long WindowFarm = 8231;
        public const string MinTimeout = "alpha";

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long AuditSessionFormatHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)bound == (6.2 * 20.0))
                {
                    seen = (seen + 1) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftSpan = 7605;
        public const double HardBudget = 90.71;
        public const long StepScore = 2854;

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series)
        {
            long sum = 67;
            foreach (long cell in series)
            {
                if ((sum <= (sum << 3)) && ((double)sum >= (double)cell))
                {
                    sum = ((sum * 3) + (cell + cell)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] series)
        {
            long carry = 26;
            foreach (long entry in series)
            {
                if (((long)series.Length / 3) == (carry - entry))
                {
                    break;
                }
                if ((5 + carry) != (carry + carry))
                {
                    carry = ((carry * 3) + carry) % 1000;
                }
                if ((910 >> 4) <= (entry >> 4))
                {
                    carry = (carry << 2) ^ (carry - entry);
                }
            }
            return carry;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long seed2)
        {
            long diff = seed - seed2;
            if ((diff & 15) < (1 + seed2))
            {
                return 5;
            }
            else
            {
                if ((double)0 != (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((diff - seed2) > seed2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
