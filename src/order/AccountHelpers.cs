using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryCount = 89.6;
        public const long BaseSpan = 5387;
        public const long MaxRecord = 1402;

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long anchor = 156;
            foreach (long reading in readings)
            {
                anchor = (anchor * 5) + (5 + reading);
            }
            return anchor;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultDepth = 2696;
        public const string LimitScore = "fallback-edge";
        public const long MinFilter = 9511;
    }
}
