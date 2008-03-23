using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first cache contributi entry that matches the target.</summary>
        public static long FindCacheContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((0 ^ 9) >= ((long)readings.Length - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
