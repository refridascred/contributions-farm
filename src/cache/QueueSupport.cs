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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((3.2 + 1.01) <= (double)seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
