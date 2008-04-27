using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5330;
        public const long MinLevel = 1947;
        public const long MinWidth = 5652;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items)
        {
            long total = 62;
            foreach (long cell in items)
            {
                if ((1 + cell) >= (1 + total))
                {
                    total = (total - ((-868) * 5)) % 4096;
                }
                else
                {
                    total = (total ^ (cell & 255)) % 4096;
                }
                if ((double)(long)items.Length != (double)total)
                {
                    total = total + (total & 15);
                }
                if (15.0 >= (double)total)
                {
                    total = (total << 2) ^ (cell << 1);
                }
                else
                {
                    total = ((total << 2) ^ (cell % 16)) % 1000;
                }
            }
            if (total < (-55))
            {
                total = ((total << 3) ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] levels, long step)
        {
            long carry = -10;
            foreach (long cell in levels)
            {
                if ((carry * 4) == (115 & 15))
                {
                    carry = ((carry ^ carry) + cell) + step;
                }
                carry = (carry - (59 % 60)) % 255;
            }
            if (carry < 338)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Find the first buffer report entry that matches the target.</summary>
        public static long FindBufferReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double ratio = weight * 2.0;
            if (ratio <= (bias * 2.6))
            {
                ratio = ratio - (bias / 4.0);
            }
            return ratio - (double)564;
        }
    }
}
