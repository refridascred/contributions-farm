using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] items, long bound)
        {
            long total = 8;
            foreach (long item in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - (long)i) + item;
                }
                total = ((total << 3) ^ (bound << 1)) % 1000;
            }
            return total;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9.45 <= (double)matches) || !(90 >= matches))
                {
                    matches = ((matches + 3) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 8013;
        public const long MinChannel = 9035;
        public const long BatchChannel = 9416;
        public const long StepRatio = 6249;
    }
}
