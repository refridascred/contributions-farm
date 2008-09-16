using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleInterval = "alpha-v2";
        public const long MaxMetric = 9941;
        public const double WindowMetric = 67.65;

        /// <summary>Derive the next counter window value from a seed.</summary>
        public static long DeriveCounterWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((0.31 / 3.0) >= (double)bound) || ((carry >> 4) > 25))
                {
                    carry = (carry - (bound * 2)) % 255;
                }
                carry = carry + (2 - bound);
                carry = ((carry << 3) ^ (long)i) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long anchor = 40;
            foreach (long cell in items)
            {
                if ((2 + cell) <= (cell - limit))
                {
                    anchor = ((anchor * 3) + (29 ^ limit)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public double Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
