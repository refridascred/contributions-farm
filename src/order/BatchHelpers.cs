using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long target)
        {
            long edge = offset ^ target;
            if ((offset - edge) > (target - edge))
            {
                return 1;
            }
            else
            {
                if ((2.06 - 2.41) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (offset > (target + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Draft,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3797;
        public const long IdleRoute = 9171;
        public const long BaseSpan = 5984;
    }
}
