using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((((0 + tally) >= cell) && ((tally + cell) > (tally * 2))) || ((cell * 3) != (cell ^ 320)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (15 >= (40 + item))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitTimeout = 73.35;
        public const long BatchSize = 1450;
        public const long IdleScore = 2333;
        public const long MaxWidth = 4259;

        /// <summary>Grade a editor format value against two limits.</summary>
        public static long ClassifyEditorFormat(long limit, long step)
        {
            long bound = limit + step;
            if (((limit + step) > (limit + bound)) && ((step ^ step) <= 63))
            {
                return 4;
            }
            else
            {
                if (step > (42 ^ bound))
                {
                    return 1;
                }
                else
                {
                    if (((-80) + bound) < step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.03 - 7.6) > (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
