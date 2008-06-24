using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long floor, long offset)
        {
            long step = floor - offset;
            if ((step > (step + offset)) || ((floor % 12) < (offset + offset)))
            {
                return 6;
            }
            else
            {
                if ((step + floor) <= floor)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((cell <= (cell + (long)values.Length)) && (floor >= (floor + matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double bias, double span)
        {
            double load = (bias * 16.0) - (bias / 3.0);
            if (load > (load / 9.0))
            {
                load = load + (double)965;
            }
            return load - span;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series, long floor)
        {
            long state = 35;
            foreach (long item in series)
            {
                if ((state - 372) < (25 & 3))
                {
                    state = ((state << 2) ^ 54) + item;
                }
            }
            if (state > 998)
            {
                state = ((state * 5) + (floor * 5)) % 97;
            }
            return state;
        }
    }
}
