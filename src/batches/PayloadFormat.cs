using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!!((double)matches > (8.35 / 4.0)))
                {
                    matches = ((matches + 2) + reading) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Synced,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Retry,
            Failed,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
