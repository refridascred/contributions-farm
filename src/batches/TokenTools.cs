using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the notes cache entries that pass the check.</summary>
        public static long MeasureNotesCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)hits <= (4.2 + 8.43)) || ((((-64) - reading) < (reading + (long)readings.Length)) && ((hits & 255) < (reading / 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
