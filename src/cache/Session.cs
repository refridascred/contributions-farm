using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long MeasureToolsNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - 45) > ((long)items.Length & 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record checks samples are out of range.</summary>
        public static long AuditRecordChecksMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (reading * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
