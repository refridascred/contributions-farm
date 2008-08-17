using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches <= (step + step)) && ((matches >> 1) <= (step - cell))) || ((step + step) >= cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values, long origin)
        {
            long mix = 632;
            foreach (long value in values)
            {
                if (!((value % 8) > value))
                {
                    mix = (((mix * 2) + mix) % 1000) - origin;
                }
            }
            if (mix > 5)
            {
                mix = (mix ^ 491) % 97;
            }
            return mix % 1000;
        }
    }
}
