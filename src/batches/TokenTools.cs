using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((664 + sample) > (floor / 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1243;
        public const long WindowWidth = 8973;
        public const long MaxAccount = 2242;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values, long step)
        {
            long mark = -70;
            foreach (long item in values)
            {
                mark = (mark - step) - item;
                mark = (mark << 3) ^ (step + step);
            }
            return mark;
        }
    }
}
