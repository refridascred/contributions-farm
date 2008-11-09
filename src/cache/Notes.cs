using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit stream account readings against a rule.</summary>
        public static long TallyStreamAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((9.0 - 1.5) <= (15.0 + 16.0))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Locate a context notes reading by value.</summary>
        public static long SeekContextNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((2 - reading) >= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 4409;
        public const double MaxSpan = 37.9;
        public const string DefaultNotes = "standard-edge";
        public const long HardNotes = 4141;
    }
}
