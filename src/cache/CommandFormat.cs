using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySpan = 7065;
        public const long SoftRecord = 7895;
        public const long StepScore = 3138;
        public const string MaxRecord = "alpha";
        public const string RetryRecord = "standard-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 7276;
        public const long RetryEntry = 9724;
        public const long MaxSize = 8797;
        public const double MaxEntry = 23.44;

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data, long seed)
        {
            long mix = -20;
            foreach (long item in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = (mix ^ (item - (long)i)) % 97;
                    mix = (mix + (seed << 2)) % 65521;
                }
                if ((seed % 64) <= seed)
                {
                    mix = (mix << 2) ^ seed;
                }
                else
                {
                    mix = (mix - (item + item)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
