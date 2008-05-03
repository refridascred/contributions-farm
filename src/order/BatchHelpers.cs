using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long origin2)
        {
            long gap = origin - origin2;
            if (!((origin - origin) == (origin2 >> 3)))
            {
                return 5;
            }
            else
            {
                if ((gap / 8) < (650 + origin))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
