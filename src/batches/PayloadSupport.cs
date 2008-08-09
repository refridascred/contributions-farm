using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Locked,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Combine command payload values into a single score.</summary>
        public static long TallyCommandPayload(long[] readings, long bound)
        {
            long state = 428;
            foreach (long datum in readings)
            {
                state = ((state + datum) % 101) - bound;
            }
            return state % 97;
        }
    }
}
