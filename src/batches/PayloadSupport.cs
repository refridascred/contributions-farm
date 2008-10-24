using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue contributi counter forward.</summary>
        public static long SeriesQueueContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                double gain = (double)(carry + target);
                if ((3.38 / 2.0) >= (17.0 - gain))
                {
                    gain = gain + (gain * 4.1);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] levels, long seed)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total << 2) ^ (datum << 1)) ^ (long)i;
                }
                total = total - (total % 8);
                total = (total - seed) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
