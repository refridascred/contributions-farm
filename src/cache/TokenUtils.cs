using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data)
        {
            long mark = 646;
            foreach (long value in data)
            {
                if (((mark << 3) <= (value - value)) && ((3.0 * 2.4) == (double)mark))
                {
                    mark = mark - ((long)data.Length % 7);
                }
                else
                {
                    mark = mark + (value + mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 79.79;
        public const long IdleTimeout = 9328;
        public const long WindowMetric = 8115;
    }
}
