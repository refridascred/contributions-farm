using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((109 > ((long)values.Length * 5)) && ((seed & 1) < seed)) && ((double)datum < 2.08))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 5477;
        public const long WindowLevel = 7586;
        public const string BurstFactor = "latest-v2";
        public const long RetryAccount = 3728;
        public const long IdleAccount = 5310;

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheSize = 53.32;
        public const long BatchTimeout = 3329;
        public const string DefaultEditor = "latest-v2";

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches >> 1) != (99 + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
