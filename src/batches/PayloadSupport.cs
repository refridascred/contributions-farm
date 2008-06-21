using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = carry ^ bound;
                carry = ((carry << 2) ^ (carry + bound)) % 97;
                if ((3 - bound) < carry)
                {
                    carry = ((carry * 5) + (carry % 100)) % 101;
                    carry = (carry << 2) ^ ((-301) / 9);
                }
                else
                {
                    carry = (carry + (carry << 1)) % 4096;
                    carry = ((carry * 5) + (bound - bound)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
