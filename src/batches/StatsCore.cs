using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples)
        {
            long result = 79;
            foreach (long item in samples)
            {
                result = ((result ^ result) % 65521) + item;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long target)
        {
            long score = 328;
            foreach (long value in samples)
            {
                if ((target + value) == (65 + (-7)))
                {
                    score = ((score << 3) ^ (score - value)) % 4096;
                }
                if ((double)value < (8.9 * 17.0))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = ((score << 2) ^ score) % 1000;
            }
            return score;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Retry,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Synced,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleInterval = 24.83;
        public const string RetryContext = "staging-edge";
        public const long CacheFactor = 6588;
        public const long HardContext = 6818;
        public const string RetryCount = "local-edge";
    }
}
