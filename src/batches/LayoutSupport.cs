using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - value) > (value ^ value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long offset, long origin)
        {
            long bound = offset - origin;
            if (((bound + origin) == (bound / 9)) || ((offset / 3) <= bound))
            {
                return 4;
            }
            else
            {
                if ((736 >> 2) >= (offset * 3))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound > 98) || ((offset - 22) != (origin - offset)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            New,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long result = 5;
            foreach (long cell in levels)
            {
                if ((536 - cell) >= (result * 4))
                {
                    result = (result << 2) ^ (cell + result);
                    continue;
                }
                else
                {
                    result = ((result * 5) + (cell % 10)) % 97;
                }
                if (((8 / 4) <= cell) && (7.5 < (double)cell))
                {
                    result = result - (cell + 0);
                }
                else
                {
                    result = (result * 2) + (cell * 2);
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long state = 650;
            foreach (long reading in items)
            {
                state = (state ^ (5 % 60)) % 1000;
                if ((reading + 618) <= state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
