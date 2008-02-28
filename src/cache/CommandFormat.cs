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

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchLevel = 6.62;
        public const double MinSpan = 86.45;
        public const string BurstAlready = "staging-1";
    }
}
