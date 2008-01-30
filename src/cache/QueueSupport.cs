using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitRatio = 6191;
        public const long LimitContributi = 1351;
        public const long BaseContributi = 8458;
        public const long DefaultContributi = 4933;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((matches + reading) < (1 + step)) || ((95 << 3) == (matches / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 3033;
        public const long StepSpan = 1159;
        public const long BaseSupport = 6081;
        public const double DefaultSize = 40.39;
    }
}
