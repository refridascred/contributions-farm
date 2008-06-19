using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((79 ^ entry) >= (step + step)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 748;
        public const string MinRoute = "strict";
        public const long RetryRoute = 2212;
        public const long CacheRoute = 3569;
        public const string MaxLevel = "stable-1";
    }
}
