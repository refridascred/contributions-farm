using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 6962;
        public const string IdleTimeout = "staging-1";
        public const long StepTimeout = 4338;
        public const long BurstReport = 3037;
        public const string MaxReport = "local-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "legacy-edge";
        public const double MinChecks = 65.68;
        public const long DefaultWidth = 3169;
        public const string HardChecks = "stable";
        public const long HardSize = 6638;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((-132) + count) == (item >> 4))
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already commits sample.</summary>
        public static long SeekAlreadyCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long seed, long offset)
        {
            long bound = seed ^ offset;
            if ((seed - offset) < (offset - 62))
            {
                return 6;
            }
            else
            {
                if ((offset & 255) < (bound >> 4))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
