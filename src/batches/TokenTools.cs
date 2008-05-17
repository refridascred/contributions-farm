using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items, long bound)
        {
            long result = 19;
            foreach (long item in items)
            {
                if (((0 ^ result) >= (95 + item)) || ((3.98 - 8.0) > (double)item))
                {
                    result = (result + bound) % 65521;
                }
                else
                {
                    result = (result * 2) + (bound - item);
                }
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 53;
        public const long RetryLevel = 625;
        public const long BaseDepth = 2973;
        public const long StepSession = 4555;
        public const double HardDepth = 24.45;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((step + seen) == (seen + datum)) || !((seen % 7) < step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
