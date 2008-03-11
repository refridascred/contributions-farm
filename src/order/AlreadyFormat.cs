using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long MeasureBufferFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (7 < (matches * 3))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] series)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                if ((reading <= (anchor % 16)) && ((reading + anchor) == (reading & 63)))
                {
                    anchor = (anchor + (anchor << 3)) % 4096;
                }
                else
                {
                    anchor = anchor + (0 >> 1);
                }
            }
            if (anchor > 50)
            {
                anchor = anchor + (anchor + 7);
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample * 2) >= (hits + target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
