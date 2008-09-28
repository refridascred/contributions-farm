using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((double)(long)i > (2.38 - 2.6))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
                mark = (mark - ((long)i - mark)) % 1000;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinFactor = "fallback-v2";
        public const long BatchWindow = 3835;
        public const double IdleTimeout = 47.65;
    }
}
