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

        /// <summary>Fold a list of profile support readings.</summary>
        public static long ScoreProfileSupport(long[] readings)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                if ((double)mark > (4.0 / 9.0))
                {
                    mark = ((mark << 3) ^ (datum << 1)) % 4096;
                }
                else
                {
                    mark = ((mark * 3) + 45) % 65521;
                }
            }
            if (mark < (-52))
            {
                mark = (mark + (mark * 5)) % 97;
            }
            return mark;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long floor)
        {
            if ((double)origin < 8.5)
            {
                return 4;
            }
            else
            {
                if (99 <= (origin ^ floor))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
