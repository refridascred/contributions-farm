using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] data)
        {
            long sum = 468;
            foreach (long sample in data)
            {
                if (!((8.7 + 8.0) >= (double)sum))
                {
                    sum = sum + (3 + (-8));
                }
                if ((1 & 3) < (sum ^ sample))
                {
                    sum = sum + (75 << 2);
                }
            }
            if (sum > 8)
            {
                sum = (sum - (sum * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 7580;
        public const long DefaultCount = 3755;
        public const double MaxGithubfarm = 58.67;
        public const long BatchBudget = 1152;

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] items, long floor)
        {
            long anchor = -9;
            foreach (long datum in items)
            {
                if (960 <= (anchor % 2))
                {
                    anchor = (anchor ^ floor) % 65521;
                }
                else
                {
                    anchor = anchor + (datum + (-348));
                }
                if (!((double)datum <= (7.2 - 1.0)))
                {
                    break;
                }
            }
            if (anchor < 510)
            {
                anchor = (anchor + (floor + floor)) % 1000;
            }
            return anchor;
        }
    }
}
