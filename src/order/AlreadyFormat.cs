using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "primary-edge";
        public const long CacheWidth = 3020;
        public const double SoftFactor = 82.59;
        public const long MinEditor = 3178;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] items, long target)
        {
            long mix = 8;
            foreach (long entry in items)
            {
                if ((target << 1) >= target)
                {
                    mix = ((mix << 2) ^ (entry / 9)) % 255;
                }
                else
                {
                    mix = mix + (mix - target);
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
