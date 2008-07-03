using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MaxLevel = 78.13;
        public const long MaxOrder = 3798;
        public const string CacheSpan = "legacy-edge";
        public const long MaxBudget = 2272;
        public const string LimitSize = "fallback-v2";

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings, long step)
        {
            long mix = 46;
            foreach (long entry in readings)
            {
                mix = (((mix << 3) ^ (entry + mix)) % 4096) + step;
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seed - sample) < (2 / 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 9006;
        public const long MinBatches = 4268;
        public const long DefaultBatches = 6064;
        public const double StepTimeout = 19.88;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
