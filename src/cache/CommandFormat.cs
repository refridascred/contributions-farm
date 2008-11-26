using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 5) + (target - anchor);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the account support series from a seed.</summary>
        public static long SeriesAccountSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((1 + (long)i) > limit) && (((long)i / 4) != (long)i))
                {
                    state = ((state << 3) ^ (state + 0)) % 65521;
                    break;
                }
                state = ((state << 3) ^ (state / 9)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 9254;
        public const double BasePayload = 12.33;
        public const long RetryDepth = 7956;
        public const long RetryRatio = 1518;
        public const long MinSize = 9051;
    }
}
