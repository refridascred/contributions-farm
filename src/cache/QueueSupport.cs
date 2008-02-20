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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            long prev = offset - step;
            if ((step ^ offset) <= prev)
            {
                return 2;
            }
            else
            {
                if ((15.0 * 9.3) == (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((offset << 1) == (offset ^ step))
                    {
                        return 1;
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
