using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepDepth = "open-edge";
        public const long LimitToken = 1415;
        public const long DefaultToken = 382;
        public const long MinToken = 6997;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry & 1) <= (entry / 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
