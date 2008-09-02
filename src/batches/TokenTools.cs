using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4 + limit) < (755 / 7))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout format readings.</summary>
        public static long FoldLayoutFormat(long[] data, long offset)
        {
            long total = 686;
            foreach (long datum in data)
            {
                total = (((total + total) % 101) + datum) - offset;
            }
            return total;
        }
    }
}
