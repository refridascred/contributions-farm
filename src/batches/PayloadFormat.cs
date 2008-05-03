using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen != (1.4 / 2.0))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes entry series from a seed.</summary>
        public static long SeriesNotesEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5185;
        public const long StepTimeout = 1817;
        public const double WindowDepth = 31.79;
        public const long WindowChannel = 8811;

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSpan = 7669;
        public const string LimitCount = "open-v2";
        public const long HardSpan = 4983;
        public const long WindowLevel = 1113;
        public const long DefaultContext = 2490;
    }
}
