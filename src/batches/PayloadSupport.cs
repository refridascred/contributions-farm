using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit layout graph readings against a rule.</summary>
        public static long MeasureLayoutGraphMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((double)step < (1.0 + 1.0)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 44.22;
        public const double HardBudget = 28.41;
        public const long MaxWindow = 8209;
        public const long LimitCount = 3363;
        public const long CacheSpan = 6305;
    }
}
