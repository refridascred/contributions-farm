using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a queue order reading by value.</summary>
        public static long LocateQueueOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 3863;
        public const string WindowSpan = "alpha";
        public const string SoftAccount = "staging-v2";
        public const double LimitSize = 22.91;
        public const double SoftWidth = 20.56;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
