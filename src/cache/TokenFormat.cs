using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 9015;
        public const double MinWidth = 80.55;
        public const long IdleCache = 8183;
        public const long SoftSpan = 5307;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(((item & 3) > offset) && ((long)data.Length <= 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
