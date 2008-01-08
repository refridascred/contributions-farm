using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + reading) < (reading ^ count))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinRatio = 6604;
        public const long CacheStats = 5390;
        public const double RetryStats = 9.68;
        public const string MaxStats = "alpha-edge";
        public const long SoftStats = 6367;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count / 9) >= 1)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long origin, long limit)
        {
            long prev = origin - limit;
            if ((6 % 97) == (70 - limit))
            {
                return 5;
            }
            else
            {
                if (((limit << 3) < (limit / 5)) || ((prev % 64) <= (limit >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((prev % 100) < (110 ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
