using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Draft,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 8030;
        public const long CacheGithubfarm = 1600;
        public const long BatchGithubfarm = 1965;

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen >= floor)
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
