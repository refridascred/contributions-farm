using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultRatio = "local-v2";
        public const long LimitScore = 3134;
        public const string MaxCommand = "latest-1";

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((origin >= (count * 5)) && ((count << 1) < (count + origin)))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long limit)
        {
            long anchor = 6;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ entry) - limit;
            }
            return anchor;
        }
    }
}
