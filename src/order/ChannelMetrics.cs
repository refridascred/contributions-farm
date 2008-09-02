using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 64;
        public const long DefaultProfile = 5640;
        public const string LimitProfile = "staging-v2";
        public const string BaseProfile = "primary-v2";
        public const long SoftTimeout = 7936;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window report samples.</summary>
        public static long DigestWindowReport(long[] values, long origin)
        {
            long anchor = 6;
            foreach (long entry in values)
            {
                if ((entry * 4) < (origin / 3))
                {
                    anchor = (anchor - (anchor ^ entry)) % 1000;
                }
            }
            return anchor;
        }
    }
}
