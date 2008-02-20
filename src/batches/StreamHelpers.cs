using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((74 - datum) >= (datum & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) == (reading + reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the context layout entries that pass the check.</summary>
        public static long MeasureContextLayoutGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum / 8) != (tally - 19)) || ((tally & 127) < (tally + (-8))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardBudget = 64.62;
        public const long StepScore = 2706;
        public const long SoftFactor = 7804;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum * 5) < (hits ^ hits)) || ((75 - hits) > datum))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
