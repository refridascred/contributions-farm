using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            New,
            Pending,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = carry + (carry % 100);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
