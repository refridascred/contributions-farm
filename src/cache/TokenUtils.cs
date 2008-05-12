using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 7260;
        public const long DefaultLevel = 3146;
        public const long MinNotes = 7672;
        public const string WindowNotes = "staging-1";
        public const long SoftNotes = 3908;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples, long target)
        {
            long anchor = 841;
            foreach (long entry in samples)
            {
                if (target <= (76 * 2))
                {
                    anchor = anchor + (entry << 3);
                }
                else
                {
                    anchor = anchor ^ (target + entry);
                }
            }
            if (anchor > 316)
            {
                anchor = anchor ^ (target & 127);
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long mark = 644;
            foreach (long entry in values)
            {
                mark = ((mark << 2) ^ entry) % 97;
            }
            return mark % 1000;
        }
    }
}
