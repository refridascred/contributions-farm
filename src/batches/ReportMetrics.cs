using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) == (sample - sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell % 5) > (cell & 255))
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
