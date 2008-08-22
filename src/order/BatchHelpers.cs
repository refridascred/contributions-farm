using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Active,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long AuditToolsStreamHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((double)value != (double)1) && ((seen - seen) == (target ^ value)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
