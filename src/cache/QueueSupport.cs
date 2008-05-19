using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum ^ seed) == (seed >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long bound)
        {
            long offset = limit - bound;
            if ((double)offset > (3.79 * 3.92))
            {
                return 0;
            }
            else
            {
                if ((offset & 1) == (limit >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound + limit) < (limit + 723))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (bound >= (seen ^ value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
