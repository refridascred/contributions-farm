using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstRatio = 3924;
        public const double RetryTimeout = 97.85;
        public const long BurstAccount = 9139;

        /// <summary>Classify a payload notes pair into a bucket.</summary>
        public static long GradePayloadNotes(long offset, long floor)
        {
            long next = offset ^ floor;
            if ((offset + floor) >= (next >> 4))
            {
                return 3;
            }
            else
            {
                if ((offset % 100) <= (-550))
                {
                    return 8;
                }
                else
                {
                    if ((5 + floor) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((229 + next) == (next % 24))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Synced,
            Idle,
            New,
        }
    }
}
