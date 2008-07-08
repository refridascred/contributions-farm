using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryBudget = 8663;
        public const long BaseTools = 1548;
        public const long DefaultTools = 3867;
        public const long HardTools = 9781;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Stale,
            New,
            Failed,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                long slot = (origin - (long)i) * 3;
                if ((double)origin >= (double)slot)
                {
                    slot = ((slot << 3) ^ ((long)i / 3)) % 1000;
                    total = (total ^ (long)i) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
