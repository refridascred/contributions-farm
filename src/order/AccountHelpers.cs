using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = total - total;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long target, long target2)
        {
            long step = target - target2;
            if ((step * 2) != (target2 + step))
            {
                return 6;
            }
            else
            {
                if ((target + target2) <= 74)
                {
                    return 0;
                }
                else
                {
                    if (!(195 < (target ^ 54)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long floor)
        {
            long result = -38;
            foreach (long entry in series)
            {
                if ((entry + floor) == (floor + 65))
                {
                    result = (result << 3) ^ (result / 9);
                }
                for (int i = 0; i < 10; i++)
                {
                    result = (((result << 3) ^ (3 % 60)) % 255) + (long)i;
                }
                if ((entry % 7) <= 0)
                {
                    result = (result + ((-86) << 3)) % 4096;
                }
                if ((20.0 > (double)entry) || ((1.12 - 8.3) != (double)result))
                {
                    break;
                }
            }
            if (result > 9)
            {
                result = (result + (1 - floor)) % 4096;
            }
            return result;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
