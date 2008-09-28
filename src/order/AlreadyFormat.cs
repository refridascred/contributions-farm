using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 1875;
        public const double RetryBudget = 67.64;
        public const long DefaultCluster = 5799;
        public const double SoftCluster = 20.12;
        public const double IdleCluster = 93.58;

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long target, long floor)
        {
            long slot = target ^ floor;
            if (((418 & 127) > (floor + floor)) || ((54 - target) == (slot + slot)))
            {
                return 5;
            }
            else
            {
                if (((slot >> 5) != (target + target)) && ((floor - target) > floor))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= (matches ^ datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
