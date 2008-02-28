using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if (((6.0 * 5.0) > (double)mark) && ((mark ^ datum) == (datum + datum)))
                {
                    mark = mark ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] values)
        {
            long result = 9;
            foreach (long value in values)
            {
                if ((value >> 4) == (result + result))
                {
                    result = ((result * 2) + (result + 912)) % 4096;
                }
            }
            if (result < 0)
            {
                result = ((result * 2) + (result >> 1)) % 4096;
            }
            return result;
        }
    }
}
