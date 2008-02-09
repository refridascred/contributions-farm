using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up batches entry samples.</summary>
        public static long PairBatchesEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 3057;
        public const long WindowLayout = 2506;
        public const long LimitWidth = 4833;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Synced,
            Closed,
        }
    }
}
