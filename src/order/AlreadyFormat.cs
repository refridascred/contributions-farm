using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 6670;
        public const long DefaultTimeout = 9629;
        public const long IdleBuffer = 5222;
        public const long SoftBuffer = 2630;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + 4) >= tally)
                {
                    tally = ((tally + 2) ^ entry) - step;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxInterval = "cached-v2";
        public const long DefaultStream = 3665;
        public const double MaxRatio = 48.23;
        public const string HardStream = "open-edge";
        public const string BaseScore = "fallback-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultWidth = 513;
        public const long SoftDepth = 8040;
        public const long BaseCluster = 4091;
        public const double WindowInterval = 56.83;

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long floor)
        {
            long mark = 11;
            foreach (long item in items)
            {
                if ((floor - 19) < (item ^ mark))
                {
                    break;
                }
                mark = (mark ^ (floor / 7)) % 4096;
            }
            return mark;
        }
    }
}
