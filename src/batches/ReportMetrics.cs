using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                if ((72 & 127) >= step)
                {
                    carry = (carry ^ ((long)i - carry)) % 255;
                    carry = (carry << 2) ^ (step << 3);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
