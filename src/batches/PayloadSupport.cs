using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many already editor samples are out of range.</summary>
        public static long CountAlreadyEditorGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((1 + matches) > (limit + matches)) && !((cell - limit) <= (cell + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            New,
            Stale,
            Idle,
        }
    }
}
