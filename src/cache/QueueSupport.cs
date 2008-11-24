using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long target)
        {
            long edge = offset + target;
            if (((edge * 2) < target) && ((edge + offset) <= (edge * 4)))
            {
                return 6;
            }
            else
            {
                if ((7.9 + 3.29) < (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target >= edge) && ((20 * 2) < offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

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
