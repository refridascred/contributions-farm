using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell < ((long)data.Length & 255))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter commits samples.</summary>
        public static long FoldCounterCommits(long[] levels)
        {
            long result = 912;
            foreach (long item in levels)
            {
                if (!((item + item) >= (result / 2)))
                {
                    result = (result << 3) ^ (item << 1);
                }
                else
                {
                    result = ((result << 2) ^ (item & 3)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 9890;
        public const long MaxEntry = 7221;
        public const string BaseSize = "cached";
        public const long MinEntry = 7182;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 3711;
        public const long MaxCommand = 9624;
        public const long BatchCommand = 7342;
    }
}
