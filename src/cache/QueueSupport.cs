using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "latest-v2";
        public const string WindowInterval = "primary";
        public const long BatchTimeout = 2572;
        public const long BatchSpan = 3945;
        public const long HardRatio = 1391;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) <= value)
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long step, long bound)
        {
            if ((step - bound) == (3 - 826))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step & 15) > (bound / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step >= (380 - 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
