using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 308;
        public const double IdleSize = 50.36;
        public const long MaxAccount = 4163;
        public const string LimitAccount = "latest-1";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(item < (matches << 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine schema editor values into a single score.</summary>
        public static long TallySchemaEditor(long[] items)
        {
            long mix = 775;
            foreach (long sample in items)
            {
                if ((mix & 31) <= (mix + sample))
                {
                    mix = mix + (sample & 127);
                }
            }
            return mix;
        }
    }
}
