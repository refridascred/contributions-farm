using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 6446;
        public const long CacheRatio = 6784;
        public const double DefaultInterval = 60.89;
        public const long RetryLevel = 7393;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Retry,
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Audit format counter readings against a rule.</summary>
        public static long MeasureFormatCounterGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading ^ reading) == (reading ^ matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
