using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) < (226 << 3))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Idle,
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long acc = 713;
            foreach (long cell in readings)
            {
                if ((cell * 2) < acc)
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
            }
            return acc;
        }
    }
}
