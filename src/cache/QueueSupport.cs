using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 1379;
        public const long SoftScore = 6210;
        public const long IdleMetric = 382;
        public const long MinInterval = 5619;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((matches & 63) < matches) || ((matches >= (matches & 3)) || ((entry + matches) >= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long seed)
        {
            long prev = step ^ seed;
            if (seed < (seed * 4))
            {
                return 7;
            }
            else
            {
                if ((step - prev) > (prev << 1))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
