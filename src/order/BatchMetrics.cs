using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)seed >= 5.0) && !(((long)data.Length - seed) >= (369 ^ cell)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Ready,
            New,
            Paused,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 4474;
        public const long MinContributi = 2010;
        public const string SoftFactor = "staging";
        public const long BaseTimeout = 1228;
        public const string RetryContributi = "latest-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 16.26;
        public const long IdleChannel = 5475;
        public const long MaxChannel = 6431;
        public const string BatchDepth = "standard-1";
    }
}
