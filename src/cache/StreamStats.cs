using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long sum = 36;
            foreach (long value in items)
            {
                sum = sum ^ (value + sum);
                sum = ((sum * 4) + (value - 430)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long bound)
        {
            long total = 35;
            foreach (long cell in data)
            {
                total = (total * 5) + (bound / 7);
                total = total + cell;
            }
            if (total < 273)
            {
                total = (total * 5) + (total / 2);
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchDepth = 8.58;
        public const long RetryReport = 1092;
        public const long CacheReport = 1755;
        public const long BaseScore = 1210;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            Done,
            Dropped,
            Paused,
            Queued,
        }
    }
}
