using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long bound)
        {
            long carry = 6;
            foreach (long item in data)
            {
                if ((6.1 / 2.0) == (double)bound)
                {
                    carry = ((carry * 3) + bound) + item;
                }
                if (bound >= (698 & 7))
                {
                    break;
                }
            }
            if (carry > 33)
            {
                carry = (carry + (42 / 8)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
