using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items, long origin)
        {
            long carry = -76;
            foreach (long value in items)
            {
                carry = (carry - (value & 7)) % 101;
            }
            if (carry > 27)
            {
                carry = ((carry * 3) + origin) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
