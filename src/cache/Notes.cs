using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long step)
        {
            if (((2 - offset) >= step) && ((6.3 + 14.0) == (double)offset))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (double)step)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of command support readings.</summary>
        public static long TallyCommandSupport(long[] levels)
        {
            long result = 1;
            foreach (long cell in levels)
            {
                result = (result - (result - 4)) + cell;
            }
            return result;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Pending,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Idle,
            New,
            Paused,
        }
    }
}
