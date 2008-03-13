using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long bound, long floor)
        {
            long cur = bound + floor;
            if ((bound ^ floor) > (cur & 15))
            {
                return 8;
            }
            else
            {
                if (bound < (bound * 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long limit2)
        {
            long step = limit + limit2;
            if (((limit2 ^ step) < (limit2 * 4)) && (limit < (step % 60)))
            {
                return 3;
            }
            else
            {
                if ((limit2 <= (92 << 2)) || (step < limit2))
                {
                    return 5;
                }
                else
                {
                    if (step < (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit2 == (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile notes entry stays within the limit.</summary>
        public static bool VerifyProfileNotesRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long state = 99;
            foreach (long value in series)
            {
                state = state - (value & 7);
            }
            if (state < 9)
            {
                state = (state ^ (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Queued,
            Paused,
        }
    }
}
