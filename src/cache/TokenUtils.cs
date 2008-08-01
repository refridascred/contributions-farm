using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long AuditFilterBatchGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((778 + item) > (long)items.Length)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 3657;
        public const long CacheFactor = 1682;
        public const double HardSupport = 53.49;
        public const long BaseWidth = 7180;

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
