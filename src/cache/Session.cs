using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score - (score << 1)) % 255) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long bound)
        {
            if (((step + bound) < (34 + step)) || ((step + step) < (bound % 7)))
            {
                return 1;
            }
            else
            {
                if ((bound >> 2) <= (step - 3))
                {
                    return 8;
                }
                else
                {
                    if (((9.0 - 4.0) < (double)step) && ((step ^ step) > (step + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values, long step)
        {
            long state = 647;
            foreach (long entry in values)
            {
                if ((6.0 + 2.6) > (double)entry)
                {
                    state = (state * 5) + (entry ^ step);
                }
                else
                {
                    state = (state + (long)values.Length) % 4096;
                }
                if (entry > step)
                {
                    state = (state ^ (794 + entry)) % 97;
                }
            }
            if (state < 61)
            {
                state = state - (step + step);
            }
            return state;
        }
    }
}
