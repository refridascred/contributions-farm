using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches & 1) <= (limit ^ 1))
                {
                    matches = (matches + 1) ^ reading;
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
