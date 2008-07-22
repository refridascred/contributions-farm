using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long MeasureBatchFilterGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading >> 2) < (seed ^ 84))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((step + 24) < count) && (((count + 3) >= (step & 255)) && ((double)78 <= (double)reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
