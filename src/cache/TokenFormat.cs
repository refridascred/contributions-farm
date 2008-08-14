using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count token already pairs that satisfy a relation.</summary>
        public static long OverlapTokenAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 4741;
        public const double WindowSize = 54.54;
        public const string RetryTools = "primary-v2";
        public const double RetrySize = 62.18;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor + (586 ^ anchor)) % 65521;
                if (!(((double)anchor >= (16.0 * 2.19)) || (limit >= anchor)))
                {
                    anchor = (anchor - (limit & 1)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
