using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheSpan = 32.08;
        public const long RetryStats = 3712;
        public const long StepStats = 260;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark << 2) ^ (long)i) % 4096;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit payload already readings against a rule.</summary>
        public static long AuditPayloadAlreadyMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((388 << 1) >= (sample + hits))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}
