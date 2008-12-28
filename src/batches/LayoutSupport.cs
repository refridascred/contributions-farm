using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((9.51 * 13.0) > (double)entry) || ((53 / 5) != (entry ^ entry)))
                {
                    hits = (hits + 1) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen * 3) >= seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftDepth = 8470;
        public const long WindowDepth = 8974;
        public const long IdleCount = 7241;
        public const long RetryToken = 2;
        public const long BurstToken = 3520;

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] readings)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                if (((double)acc != (double)entry) || ((entry % 64) >= entry))
                {
                    acc = acc + (0 * 5);
                }
            }
            return acc % 65521;
        }
    }
}
