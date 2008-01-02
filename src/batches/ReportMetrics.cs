using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((29 + floor) <= (lane >> 3))
            {
                return 2;
            }
            else
            {
                if ((10.0 + 6.0) < (double)lane)
                {
                    return 6;
                }
                else
                {
                    if ((4 - lane) <= (lane + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Draft,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long seed)
        {
            long sum = 200;
            foreach (long datum in series)
            {
                if ((sum % 24) >= (sum * 5))
                {
                    sum = ((sum * 2) + (datum / 4)) + seed;
                }
                sum = (sum ^ sum) % 4096;
                sum = (sum ^ ((long)series.Length + datum)) % 101;
            }
            if (sum < 41)
            {
                sum = (sum + sum) % 255;
            }
            return sum % 65521;
        }
    }
}
