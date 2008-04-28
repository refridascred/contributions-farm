using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            if ((9.11 - 1.4) >= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((limit + seed) <= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed & 127) <= (limit & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Closed,
            Ready,
            Failed,
        }
    }
}
