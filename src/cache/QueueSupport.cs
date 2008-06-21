using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels)
        {
            long carry = 80;
            foreach (long value in levels)
            {
                if ((carry * 2) >= (carry << 3))
                {
                    carry = ((carry << 2) ^ (carry % 64)) % 101;
                    carry = (carry - (value - 6)) % 1000;
                }
                else
                {
                    carry = (carry - (406 % 5)) % 4096;
                    carry = (carry - (value << 1)) % 65521;
                }
                carry = (carry + value) % 101;
            }
            return carry;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
