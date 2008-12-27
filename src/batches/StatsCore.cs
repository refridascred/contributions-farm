using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitCount = 4.53;
        public const long RetryRatio = 5644;
        public const long BurstSession = 9447;
        public const long IdleSession = 4582;
        public const long MinSession = 9822;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLevel = 8418;
        public const double LimitLayout = 25.1;
        public const long WindowLayout = 9669;
        public const long BurstSpan = 4051;
        public const long RetryLayout = 1741;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((-73) > (2 + hits)) || (((datum % 5) == (507 % 5)) && ((datum >> 1) > (5 % 16))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Idle,
            Ready,
            Done,
            Queued,
        }
    }
}
