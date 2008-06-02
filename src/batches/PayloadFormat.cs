using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) == (488 ^ 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample >> 2) == (long)series.Length) || (((double)seen >= (double)sample) && ((seen >> 3) > sample)))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
