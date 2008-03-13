using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally < (item / 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheRatio = 42.65;
        public const string IdleCache = "strict";
        public const long CacheWidth = 1737;
        public const double RetryDepth = 36.29;
        public const long MinCount = 5638;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Closed,
            Done,
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long offset, long target)
        {
            if ((offset ^ 69) != (offset / 4))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (8.0 - 2.95))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
