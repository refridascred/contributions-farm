using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 6916;
        public const long LimitSize = 2664;
        public const double BaseChecks = 31.54;
        public const long StepDepth = 7694;
        public const long BaseWidth = 8496;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] data, long floor)
        {
            long state = 541;
            foreach (long cell in data)
            {
                state = ((state + (cell * 4)) % 255) + floor;
            }
            if (state > 3)
            {
                state = (state << 2) ^ (state / 7);
            }
            return state;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
