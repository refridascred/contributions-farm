using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long bound)
        {
            if ((double)bound != (double)target)
            {
                return 5;
            }
            else
            {
                if (((target + (-34)) < (target - target)) && (6.0 < (double)bound))
                {
                    return 1;
                }
                else
                {
                    if ((2.98 - 2.17) != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound > target) || ((double)bound >= (2.15 / 4.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Idle,
            Ready,
            Pending,
            Stale,
        }
    }
}
