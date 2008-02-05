using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches / 8) != (item % 5))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((13.0 + 3.97) < (double)seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long offset, long step)
        {
            long slot = offset - step;
            if ((slot - slot) < step)
            {
                return 4;
            }
            else
            {
                if ((slot + 76) != (slot >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (4.01 - 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Locked,
            Ready,
        }
    }
}
