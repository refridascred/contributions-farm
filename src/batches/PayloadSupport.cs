using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine schema command values into a single score.</summary>
        public static long DigestSchemaCommand(long[] values)
        {
            long state = 37;
            foreach (long reading in values)
            {
                if (state >= (state & 63))
                {
                    state = ((state * 3) + state) % 1000;
                }
                else
                {
                    state = state + (reading >> 5);
                }
                if (((3.8 / 4.0) != (double)reading) || ((6.2 - 3.0) == (double)reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Paused,
            Failed,
            Pending,
        }
    }
}
