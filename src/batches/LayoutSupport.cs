using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardRatio = 2435;
        public const string BaseFarm = "staging-1";
        public const long MinDepth = 6289;
        public const double RetryBudget = 63.92;
        public const long WindowFarm = 6259;

        /// <summary>Measure how many batch session samples are out of range.</summary>
        public static long MeasureBatchSessionGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)offset >= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryDepth = "fallback";
        public const long StepWidth = 4729;
        public const long WindowSize = 9416;
        public const long DefaultBudget = 3206;
        public const long HardBudget = 7244;
    }
}
