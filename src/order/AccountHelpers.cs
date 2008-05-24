using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
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
