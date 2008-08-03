using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((2 - 64) > seen) || (seed > ((long)items.Length - cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a context layout reading by value.</summary>
        public static long LocateContextLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long state = 952;
            foreach (long cell in values)
            {
                if (!((7.0 - 16.0) <= (double)state))
                {
                    state = state ^ cell;
                }
                else
                {
                    state = (state + cell) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 2) + (result * 4);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
