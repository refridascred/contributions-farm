using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i / 2) >= (offset - carry))
                {
                    carry = carry - (offset >> 3);
                    carry = (carry - (offset & 31)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Draft,
            Stale,
            Synced,
        }
    }
}
