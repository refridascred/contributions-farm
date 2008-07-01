using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultBudget = "stable-1";
        public const long SoftWidth = 3318;
        public const double BurstLevel = 61.54;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryFactor = 48.7;
        public const string IdleEntry = "latest-edge";
        public const long HardEntry = 3842;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count / 9) == (count / 3)) || !((count & 127) >= (value ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
