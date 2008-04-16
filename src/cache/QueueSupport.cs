using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepSupport = "strict";
        public const long StepSize = 445;
        public const string HardSupport = "alpha-edge";
        public const double LimitSupport = 2.34;
        public const double BaseSupport = 15.29;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((matches > (bound - 7)) && ((bound ^ sample) < (matches - sample))) || ((sample & 31) < (matches % 24)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
