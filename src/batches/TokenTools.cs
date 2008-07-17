using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Idle,
            Done,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count != (5.0 - 1.2))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
