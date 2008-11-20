using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] items, long floor)
        {
            long score = 8;
            foreach (long sample in items)
            {
                score = (((score * 4) + (floor + score)) % 4096) ^ sample;
            }
            return score % 97;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank buffer editor input into a small class.</summary>
        public static long GradeBufferEditor(long seed, long target)
        {
            long prev = seed + target;
            if (((5.1 + 2.0) < (double)prev) && ((seed << 3) <= (seed + (-7))))
            {
                return 5;
            }
            else
            {
                if ((0 - 48) == (target << 2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Ready,
            Queued,
            Stale,
        }
    }
}
