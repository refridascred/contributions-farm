using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the report stream series from a seed.</summary>
        public static long StepReportStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (limit & 127)) % 97;
                acc = acc - (acc % 12);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long step, long seed)
        {
            if ((double)step < (7.79 * 6.0))
            {
                return 3;
            }
            else
            {
                if ((double)seed > (6.4 + 5.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Ready,
            Pending,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 21.66;
        public const string SoftTimeout = "strict";
        public const long RetrySession = 3296;
    }
}
