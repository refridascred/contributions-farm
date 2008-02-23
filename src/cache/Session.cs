using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 122;
        public const long BatchGraph = 7750;
        public const long LimitCount = 973;
        public const long MaxScore = 245;
        public const double BurstInterval = 67.44;

        /// <summary>Measure how many already order samples are out of range.</summary>
        public static long TallyAlreadyOrderOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((9.0 * 4.3) > (double)count) || ((1.0 - 0.4) > (double)entry))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowRatio = 49.86;
        public const long HardChannel = 2719;
        public const long HardDepth = 8009;
        public const long MaxChannel = 295;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
