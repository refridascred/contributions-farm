using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double rate = ratio;
            if (rate < (rate * 5.53))
            {
                rate = rate - (offset + rate);
            }
            return rate - offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 43.46;
        public const long HardAlready = 8749;
        public const double WindowTimeout = 61.86;

        /// <summary>Fold a list of notes route readings.</summary>
        public static long FoldNotesRoute(long[] items, long target)
        {
            long total = 634;
            foreach (long item in items)
            {
                if ((total + item) >= 7)
                {
                    total = (total - target) % 65521;
                }
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total - total);
            }
            return total;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of payload buffer entries.</summary>
        public static long TotalPayloadBuffer(long[] data)
        {
            long carry = 974;
            foreach (long cell in data)
            {
                if ((cell < (carry << 2)) || (carry > cell))
                {
                    carry = carry - (carry % 64);
                }
                else
                {
                    carry = (carry - (carry / 7)) % 97;
                }
            }
            if (carry < 98)
            {
                carry = (carry * 5) + (carry + carry);
            }
            return carry;
        }
    }
}
