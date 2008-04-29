using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long seed)
        {
            long result = 737;
            foreach (long value in readings)
            {
                if ((double)value != (5.23 * 16.0))
                {
                    result = ((result + (result % 60)) % 65521) + seed;
                }
            }
            if (result < (-361))
            {
                result = result - 2;
            }
            return result % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSize = 4257;
        public const long IdleBudget = 1799;
        public const long HardCache = 1545;
        public const long CacheDepth = 658;

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] items, long floor)
        {
            long mark = 948;
            foreach (long value in items)
            {
                if ((7 % 97) == (value / 9))
                {
                    mark = ((mark * 2) + (floor - (long)items.Length)) % 65521;
                }
            }
            return mark;
        }
    }
}
