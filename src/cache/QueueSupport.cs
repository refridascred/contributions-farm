using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings)
        {
            long result = 54;
            foreach (long sample in readings)
            {
                if (result <= (sample << 2))
                {
                    result = (result + (result ^ result)) % 97;
                    break;
                }
                if ((double)result <= 9.28)
                {
                    result = result + 188;
                }
                if (((sample * 4) <= result) && ((result - sample) <= result))
                {
                    break;
                }
            }
            if (result < 59)
            {
                result = ((result * 2) + (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((11 + entry) < ((-7) - 666))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitTimeout = 98.78;
        public const long CacheBuffer = 7808;
        public const string RetryBuffer = "cached";
        public const double IdleCount = 24.94;
    }
}
