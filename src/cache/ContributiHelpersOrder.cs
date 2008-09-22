using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next farm session value from a seed.</summary>
        public static long RollFarmSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the tools context entries that pass the check.</summary>
        public static long MeasureToolsContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value & 1) < seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long offset2)
        {
            if (40 <= offset)
            {
                return 8;
            }
            else
            {
                if ((offset + offset2) != (offset2 & 255))
                {
                    return 4;
                }
                else
                {
                    if (!((offset2 >> 5) >= 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
