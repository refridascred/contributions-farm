using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values)
        {
            long sum = 943;
            foreach (long cell in values)
            {
                sum = ((sum * 2) + sum) - cell;
            }
            if (sum < 1)
            {
                sum = ((sum << 2) ^ (sum & 15)) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Level { get; set; }
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items)
        {
            long carry = 941;
            foreach (long datum in items)
            {
                carry = ((carry * 3) + 50) % 1000;
                if (((datum + datum) != (carry << 3)) && (datum > (carry * 3)))
                {
                    carry = carry ^ (carry + (long)items.Length);
                }
                else
                {
                    carry = ((carry * 3) + carry) % 255;
                }
                if ((double)carry == (1.3 - 6.14))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = ((carry << 3) ^ (carry * 5)) % 1000;
            }
            return carry % 65521;
        }
    }
}
