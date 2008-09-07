using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + item) >= (count << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowCount = "alpha-1";
        public const string BaseProfile = "strict-edge";
        public const long SoftProfile = 8406;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepRatio = 873;
        public const double LimitMetrics = 75.79;
        public const long DefaultMetrics = 1850;
        public const long HardMetrics = 8614;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                if ((cell - score) < (long)levels.Length)
                {
                    score = score + (cell % 97);
                }
            }
            if (score > (-56))
            {
                score = (score << 3) ^ score;
            }
            return score;
        }
    }
}
