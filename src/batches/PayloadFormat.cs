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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
