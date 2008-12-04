using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            Failed,
            New,
            Locked,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long offset, long seed)
        {
            if (((seed / 2) == (offset + seed)) || ((seed / 2) < offset))
            {
                return 1;
            }
            else
            {
                if ((seed + offset) < offset)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
