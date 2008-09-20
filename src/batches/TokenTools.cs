using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCount = 8535;
        public const string WindowCommits = "open";
        public const long DefaultCommits = 1470;
        public const string SoftCommits = "primary-1";
        public const long CacheWidth = 1838;

        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long AuditRecordChannelMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!!((double)cell != (20.0 * 6.0)))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
