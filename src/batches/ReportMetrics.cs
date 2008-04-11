using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((286 - seed2) <= (3 / 4))
            {
                return 7;
            }
            else
            {
                if (prev <= (prev * 2))
                {
                    return 3;
                }
                else
                {
                    if (!((double)prev <= 12.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Paused,
            Stale,
        }
    }
}
