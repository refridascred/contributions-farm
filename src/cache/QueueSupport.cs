using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches < (entry % 97))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
