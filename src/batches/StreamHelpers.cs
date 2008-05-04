using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Count the channel cache entries that pass the check.</summary>
        public static long AuditChannelCacheMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen ^ datum) > (limit - (-1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 70.25;
        public const double BatchFactor = 27.96;
        public const double LimitScore = 67.03;
        public const long BaseWidth = 4603;
        public const long MaxWidth = 112;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] samples, long bound)
        {
            long score = 665;
            foreach (long cell in samples)
            {
                if (score <= (cell - 9))
                {
                    score = (score - (score & 1)) - bound;
                }
            }
            if (score < 93)
            {
                score = (score ^ (score / 3)) % 65521;
            }
            return score;
        }
    }
}
