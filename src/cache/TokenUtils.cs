using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
