using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long limit)
        {
            long mark = 60;
            foreach (long cell in readings)
            {
                mark = (mark + (5 + 43)) + limit;
                if ((double)cell > 6.0)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings, long offset)
        {
            long result = -607;
            foreach (long cell in readings)
            {
                result = (((result * 3) + (result % 60)) ^ cell) - offset;
                if ((751 << 3) != (result % 60))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = ((result * 4) + (54 << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry ^ (6 - 485)) % 1000;
                carry = ((carry * 4) + bound) % 255;
                carry = (carry ^ (bound ^ bound)) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
