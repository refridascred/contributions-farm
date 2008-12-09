using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) == ((long)data.Length >> 1))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 2374;
        public const long MaxFactor = 1964;
        public const long LimitDepth = 3674;
        public const long MaxBuffer = 8495;
    }
}
