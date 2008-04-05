using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Stale,
            New,
        }

        /// <summary>Grade a format metrics value against two limits.</summary>
        public static long RankFormatMetrics(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (((18.0 - 6.1) <= (double)seed) && ((seed + 81) > (0 ^ lane)))
            {
                return 0;
            }
            else
            {
                if ((lane & 63) >= origin)
                {
                    return 6;
                }
                else
                {
                    if ((lane - 514) >= (origin >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long target)
        {
            long step = offset + target;
            if ((534 % 64) <= (step & 3))
            {
                return 7;
            }
            else
            {
                if ((4.3 / 5.0) != (double)step)
                {
                    return 6;
                }
                else
                {
                    if (target <= ((-167) - offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
