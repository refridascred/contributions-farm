using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long target, long seed)
        {
            long prev = target - seed;
            if ((((-71) % 60) != (prev / 6)) && ((target & 3) >= 85))
            {
                return 6;
            }
            else
            {
                if ((target + target) > (prev + seed))
                {
                    return 4;
                }
                else
                {
                    if (((prev / 3) == (target + 20)) && ((target - target) < (prev + prev)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxCount = 29.6;
        public const double HardWindow = 36.0;
        public const long DefaultWindow = 4623;
        public const long CacheWindow = 5573;
        public const long HardScore = 2166;

        /// <summary>Iterate the report record series from a seed.</summary>
        public static long SeriesReportRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - 37) % 101;
                if ((88 + acc) == (acc / 3))
                {
                    acc = (acc ^ (acc + 54)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (step & 1)) % 1000;
                }
                acc = (acc + (8 - (long)i)) % 101;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowSpan = 4138;
        public const double DefaultSpan = 92.38;
        public const long WindowInterval = 9750;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Locked,
            Ready,
            Failed,
            Draft,
        }
    }
}
