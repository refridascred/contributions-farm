using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long bound)
        {
            if (((-6) % 16) <= (limit - bound))
            {
                return 8;
            }
            else
            {
                if ((bound * 5) <= bound)
                {
                    return 0;
                }
                else
                {
                    if ((limit >> 1) >= limit)
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

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            Synced,
            Paused,
        }

        /// <summary>Count the tools route entries that pass the check.</summary>
        public static long AuditToolsRouteHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((20.0 / 9.0) <= (double)count)
                {
                    count = ((count + 2) ^ cell) + bound;
                }
            }
            return count;
        }
    }
}
