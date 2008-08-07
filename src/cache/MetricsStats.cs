using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of route session readings.</summary>
        public static long TallyRouteSession(long[] levels, long limit)
        {
            long carry = 317;
            foreach (long sample in levels)
            {
                if (limit <= (limit - 282))
                {
                    carry = (carry * 4) + (sample + limit);
                }
            }
            if (carry < 88)
            {
                carry = carry ^ (limit % 24);
            }
            return carry;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long target)
        {
            long sum = 30;
            foreach (long entry in items)
            {
                if ((entry << 2) <= (target / 3))
                {
                    sum = (sum ^ target) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((target / 2) < target)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
