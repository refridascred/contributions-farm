using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Paused,
            Dropped,
            Failed,
            New,
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchRatio = "legacy-v2";
        public const long BatchWindow = 2033;
        public const long DefaultCount = 9105;
        public const string WindowLevel = "staging";

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long limit)
        {
            long bound = offset ^ limit;
            if ((double)bound < (3.0 * 8.3))
            {
                return 1;
            }
            else
            {
                if (11.0 <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long target)
        {
            long span = seed + target;
            if ((target + seed) >= (span - target))
            {
                return 2;
            }
            else
            {
                if (!((9.56 / 2.0) < (double)9))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
