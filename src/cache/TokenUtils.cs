using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultTimeout = "fallback-1";
        public const long LimitLevel = 8886;
        public const long CacheBudget = 3222;
        public const long HardCommand = 829;
        public const string BatchSize = "cached-v2";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen % 16) >= (-6))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long SeriesEditorProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (5 - 6)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
