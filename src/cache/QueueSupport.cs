using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryRatio = 28.2;
        public const long BurstSpan = 2887;
        public const double WindowFilter = 86.08;
        public const long BurstDepth = 2314;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
