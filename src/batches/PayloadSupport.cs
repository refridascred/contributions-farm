using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Active,
            Dropped,
            Synced,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ 56;
                anchor = ((anchor * 4) + (anchor - anchor)) % 255;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
