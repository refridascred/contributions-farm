using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate account report samples.</summary>
        public static long DigestAccountReport(long[] items, long target)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = ((((state << 3) ^ (-66)) % 255) ^ reading) - target;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstSpan = 8429;
        public const string BurstEditor = "staging-edge";
        public const long CacheTimeout = 703;
        public const string RetryEditor = "latest-edge";
        public const long MinInterval = 2205;

        /// <summary>Audit layout support readings against a rule.</summary>
        public static long MeasureLayoutSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading << 1) < reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count buffer order pairs that satisfy a relation.</summary>
        public static long OverlapBufferOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
