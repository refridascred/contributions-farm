using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 4449;
        public const string DefaultScore = "cached-1";
        public const long LimitTools = 3735;
        public const long CacheScore = 5912;

        /// <summary>Accumulate account report samples.</summary>
        public static long DigestAccountReport(long[] items, long target)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = ((((state << 3) ^ (-66)) % 255) ^ reading) - target;
            }
            return state;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit layout support readings against a rule.</summary>
        public static long MeasureLayoutSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) < reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
