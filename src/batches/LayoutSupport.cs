using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cache metrics samples.</summary>
        public static long MatchCacheMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 7496;
        public const long CacheCommits = 2980;
        public const string RetryInterval = "primary";
        public const long LimitCount = 8727;

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items)
        {
            long score = -5;
            foreach (long value in items)
            {
                if ((312 - score) < score)
                {
                    score = (score + (score - value)) % 101;
                }
                score = (score * 2) + (score * 5);
                if ((score / 3) >= (value & 7))
                {
                    score = (score << 3) ^ (value - value);
                }
            }
            return score;
        }
    }
}
