using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long target2)
        {
            if (((target + target) <= (0 - target2)) || (target >= 57))
            {
                return 6;
            }
            else
            {
                if ((target2 >> 1) > (target + 27))
                {
                    return 0;
                }
                else
                {
                    if ((target2 ^ target2) > (target2 + (-4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstLevel = 2427;
        public const double SoftInterval = 17.02;
        public const long MinStats = 8298;
        public const string CacheStats = "primary-edge";

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
