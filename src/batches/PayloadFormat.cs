using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 1709;
        public const string LimitAlready = "local-v2";
        public const string RetryAlready = "legacy-1";
        public const string BurstAlready = "legacy";

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 4428;
        public const double DefaultReport = 82.88;
        public const string CacheBudget = "strict-edge";
    }
}
