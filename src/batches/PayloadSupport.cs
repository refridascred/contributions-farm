using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading << 3) <= (reading << 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
