using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

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

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Dropped,
            Failed,
            Idle,
            Stale,
        }
    }
}
