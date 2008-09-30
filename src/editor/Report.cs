using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 39.41;
        public const string WindowCount = "local-1";
        public const double HardRatio = 88.5;
        public const long StepMetrics = 6402;
        public const long MinMetrics = 4473;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long origin, long limit)
        {
            long prev = origin + limit;
            if ((prev & 31) > (limit >> 3))
            {
                return 3;
            }
            else
            {
                if (((920 & 7) < (prev + limit)) && ((origin - origin) <= (origin + 62)))
                {
                    return 6;
                }
                else
                {
                    if ((limit > (limit << 1)) || (origin <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long result = 912;
            foreach (long entry in values)
            {
                result = result ^ (235 - entry);
            }
            return result;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Paused,
            Locked,
            Ready,
        }
    }
}
