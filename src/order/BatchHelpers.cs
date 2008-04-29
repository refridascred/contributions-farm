using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) != (seen % 2))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Locked,
            Draft,
        }
    }
}
