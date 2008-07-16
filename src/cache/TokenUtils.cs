using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen / 2) > seen)
                {
                    seen = ((seen + 3) ^ value) + bound;
                }
            }
            return seen;
        }
    }
}
