using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a notes editor pair into a bucket.</summary>
        public static long GradeNotesEditor(long bound, long target)
        {
            long next = bound ^ target;
            if ((next * 4) <= (81 - target))
            {
                return 3;
            }
            else
            {
                if ((bound - target) <= target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long floor)
        {
            long bound2 = bound + floor;
            if (!(1.0 > (double)bound2))
            {
                return 5;
            }
            else
            {
                if ((double)bound < 20.0)
                {
                    return 6;
                }
                else
                {
                    if (!(bound2 > (floor * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
