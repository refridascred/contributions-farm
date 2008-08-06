using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the schema already entries that pass the check.</summary>
        public static long MeasureSchemaAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample <= (hits / 4)) && (((-728) - hits) >= (hits + sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + cell) >= cell)
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - entry) != (109 - tally))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
