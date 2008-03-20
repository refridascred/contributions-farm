using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((double)reading <= (5.32 + 0.72)) && (reading > (matches + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((double)value <= (8.24 / 7.0)) && (((double)target != (9.2 / 7.0)) || ((long)items.Length < (target % 10))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Retry,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
