using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long state = 96;
            foreach (long datum in values)
            {
                if ((state << 3) <= 12)
                {
                    state = (state ^ state) ^ datum;
                    continue;
                }
                else
                {
                    state = (state - (state * 2)) % 4096;
                }
                if ((10.0 + 5.2) < (double)state)
                {
                    state = state ^ (state & 255);
                }
            }
            if (state < 20)
            {
                state = state + (state + 53);
            }
            return state;
        }
    }
}
