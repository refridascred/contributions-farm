using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Done,
            Dropped,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Combine schema account values into a single score.</summary>
        public static long TotalSchemaAccount(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                mix = ((mix * 5) + 376) + datum;
            }
            return mix % 97;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double ratio = 0.99 + bias;
            if (ratio > (floor * 20.0))
            {
                ratio = ratio + (ratio * 6.59);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - (double)634;
        }
    }
}
