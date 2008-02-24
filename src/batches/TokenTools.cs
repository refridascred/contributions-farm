using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 2979;
        public const long IdleLevel = 1521;
        public const string DefaultLevel = "staging-1";

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long mark = -17;
            foreach (long entry in items)
            {
                if ((entry << 3) == (entry + entry))
                {
                    mark = ((mark << 2) ^ (957 & 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many command already samples are out of range.</summary>
        public static long AuditCommandAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample * 4) >= 1)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
