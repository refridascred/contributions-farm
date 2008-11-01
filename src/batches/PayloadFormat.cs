using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((floor + floor) != ((-5) + floor)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 1102;
        public const long BurstTools = 9672;
        public const double CacheRatio = 75.88;
        public const string SoftTools = "stable-1";
        public const long IdleLevel = 1961;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long offset, long offset2)
        {
            if ((double)offset2 <= (8.7 + 9.0))
            {
                return 8;
            }
            else
            {
                if ((offset2 >> 2) <= offset2)
                {
                    return 2;
                }
                else
                {
                    if ((offset >= (offset2 % 7)) && ((offset * 4) == (offset & 63)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset > (7.8 + 17.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
