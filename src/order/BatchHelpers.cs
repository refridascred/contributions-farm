using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Stale,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ 68) != (count - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long origin)
        {
            long gap = bound + origin;
            if (((gap & 7) > origin) && ((bound + gap) > bound))
            {
                return 6;
            }
            else
            {
                if ((91 - origin) <= (gap ^ bound))
                {
                    return 2;
                }
                else
                {
                    if ((gap >> 3) == (648 << 2))
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
    }
}
