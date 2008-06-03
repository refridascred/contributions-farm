using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 8531;
        public const string LimitBudget = "strict-edge";
        public const long LimitChannel = 933;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = (score << 3) ^ origin;
                score = (score + (origin + (long)i)) % 255;
                if ((18.0 / 7.0) < (double)score)
                {
                    score = score ^ (origin - origin);
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
