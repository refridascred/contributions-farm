using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Done,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Measure how many format already samples are out of range.</summary>
        public static long MeasureFormatAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((reading >= (hits << 2)) && (reading <= (hits - hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long target)
        {
            long edge = offset + target;
            if (target >= (edge << 1))
            {
                return 5;
            }
            else
            {
                if ((edge + target) <= (target >> 1))
                {
                    return 4;
                }
                else
                {
                    if (!(((-136) << 2) != (1 ^ offset)))
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
