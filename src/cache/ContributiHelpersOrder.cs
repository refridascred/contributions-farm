using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long total = 12;
            foreach (long sample in items)
            {
                total = (total + (sample << 2)) % 101;
                total = (total + (sample + total)) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of cluster contributi entries.</summary>
        public static long TotalClusterContributi(long[] samples, long floor)
        {
            long sum = 969;
            foreach (long cell in samples)
            {
                sum = ((sum * 4) + cell) + floor;
            }
            if (sum < 602)
            {
                sum = ((sum << 3) ^ (620 + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values)
        {
            long carry = 8;
            foreach (long cell in values)
            {
                carry = ((carry << 2) ^ (carry % 100)) % 1000;
                carry = (carry << 2) ^ carry;
                if (((double)carry >= (6.5 + 9.0)) && ((cell + 76) < (carry - cell)))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
