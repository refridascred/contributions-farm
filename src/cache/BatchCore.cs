using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Queued,
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseRatio = 6332;
        public const long CacheCommand = 2978;
        public const long StepCommand = 9884;
        public const long StepInterval = 36;
        public const string MaxWidth = "stable-1";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long target2)
        {
            long diff = target ^ target2;
            if ((target2 > (diff & 31)) && (8 < (diff * 5)))
            {
                return 4;
            }
            else
            {
                if (3.1 < (double)target2)
                {
                    return 1;
                }
                else
                {
                    if ((double)target <= 4.0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
