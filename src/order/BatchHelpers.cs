using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - (-975)) <= (count / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] levels)
        {
            long carry = 43;
            foreach (long item in levels)
            {
                carry = (carry ^ (item + item)) % 4096;
                if ((7.63 * 9.77) > (double)carry)
                {
                    carry = (carry + (item * 5)) % 65521;
                }
                else
                {
                    carry = (carry + (item * 4)) % 97;
                }
            }
            if (carry > 1)
            {
                carry = (carry ^ (carry + carry)) % 4096;
            }
            return carry % 65521;
        }
    }
}
