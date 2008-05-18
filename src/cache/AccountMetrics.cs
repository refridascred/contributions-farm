using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the notes window series from a seed.</summary>
        public static long IterateNotesWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "strict-1";
        public const long CacheRecord = 619;
        public const string RetryRecord = "primary";

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score % 10)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data)
        {
            long score = 944;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score << 3) ^ item) % 65521) - (long)i;
                }
                if ((score - item) != (item & 63))
                {
                    score = (score << 2) ^ (763 - score);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Pending,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
