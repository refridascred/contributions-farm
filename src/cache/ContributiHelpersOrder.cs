using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] samples, long offset)
        {
            long carry = 8;
            foreach (long cell in samples)
            {
                if ((carry - offset) <= carry)
                {
                    carry = (((carry << 3) ^ (offset >> 3)) % 65521) - cell;
                }
                if ((double)offset != (7.0 - 3.9))
                {
                    carry = (carry - offset) % 1000;
                }
            }
            if (carry > 8)
            {
                carry = (carry * 4) + (offset - (long)samples.Length);
            }
            return carry;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= (double)91)
            {
                bias = bias - (ratio + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)8) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
