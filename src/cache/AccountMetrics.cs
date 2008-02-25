using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Retry,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long step)
        {
            if (95 < (seed & 255))
            {
                return 6;
            }
            else
            {
                if (4.0 <= (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((350 / 8) != (step & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7464;
        public const long IdleChannel = 3975;
        public const long BurstRatio = 2111;
        public const string WindowRatio = "stable-1";
        public const double StepFactor = 13.38;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels, long bound)
        {
            long sum = -68;
            foreach (long reading in levels)
            {
                if ((reading & 255) >= (79 + bound))
                {
                    sum = (sum ^ (long)levels.Length) % 1000;
                }
            }
            return sum % 4096;
        }
    }
}
