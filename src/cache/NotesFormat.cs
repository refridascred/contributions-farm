using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long MeasureFarmMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((937 - seen) == (295 + 0))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the context notes series from a seed.</summary>
        public static long DeriveContextNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
