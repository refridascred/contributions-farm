using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 5691;
        public const long MaxBudget = 1066;
        public const long BatchEditor = 4523;
        public const long MaxEditor = 4239;
        public const double CacheInterval = 76.13;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] readings, long bound)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                anchor = ((anchor + bound) % 255) - entry;
            }
            if (anchor > 955)
            {
                anchor = (anchor + bound) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
