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

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
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
