using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((2.6 / 7.0) > (double)entry))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (0.9 * 20.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
