using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Closed,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of tools profile readings.</summary>
        public static long CombineToolsProfile(long[] levels, long bound)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = (((carry ^ (carry ^ carry)) % 97) + cell) - bound;
            }
            return carry;
        }
    }
}
