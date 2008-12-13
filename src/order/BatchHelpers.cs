using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long target2)
        {
            long edge = target - target2;
            if ((6.0 * 19.0) != (double)edge)
            {
                return 5;
            }
            else
            {
                if ((target + edge) >= (edge * 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((target + 9) >= (target & 255))
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
