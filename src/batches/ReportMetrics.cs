using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series)
        {
            long anchor = 461;
            foreach (long reading in series)
            {
                if ((reading - anchor) > 88)
                {
                    anchor = (anchor - (anchor - reading)) % 101;
                }
            }
            return anchor;
        }
    }
}
