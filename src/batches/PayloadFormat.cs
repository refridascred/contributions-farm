using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 57.17;
        public const long HardLevel = 8899;
        public const long BaseScore = 5105;

        /// <summary>Count the filter batch entries that pass the check.</summary>
        public static long TallyFilterBatchHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (719 > (target - count))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Level { get; set; }
            public double Token { get; set; }
        }
    }
}
