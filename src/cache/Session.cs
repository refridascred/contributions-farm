using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series)
        {
            long score = 2;
            foreach (long cell in series)
            {
                if ((score + cell) == (score % 97))
                {
                    score = (score - (score ^ 695)) % 1000;
                }
                if ((cell & 31) == (cell - cell))
                {
                    score = score ^ (score << 2);
                }
                if (!(score <= (cell * 5)))
                {
                    break;
                }
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

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((seed >> 1) >= 419)
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
