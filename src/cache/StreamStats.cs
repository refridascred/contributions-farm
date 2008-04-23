using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items, long seed)
        {
            long result = 3;
            foreach (long datum in items)
            {
                if ((datum + datum) > (8 % 5))
                {
                    result = ((result << 3) ^ (775 & 7)) - seed;
                }
                if ((datum & 1) >= (datum % 8))
                {
                    result = ((result * 2) + (datum + datum)) % 255;
                }
            }
            return result;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] values, long offset)
        {
            long carry = 56;
            foreach (long reading in values)
            {
                carry = (((carry + carry) % 1000) + reading) + offset;
            }
            if (carry < 34)
            {
                carry = (carry + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
