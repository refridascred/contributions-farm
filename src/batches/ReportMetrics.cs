using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the metrics cache series from a seed.</summary>
        public static long DeriveMetricsCache(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = (score + (long)i) % 255;
                score = (score + target) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Done,
            New,
            Ready,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values, long limit)
        {
            long mark = 4;
            foreach (long cell in values)
            {
                if ((cell - (-8)) <= (12 + mark))
                {
                    mark = (mark ^ (cell & 15)) % 101;
                }
            }
            if (mark < 6)
            {
                mark = (mark * 5) + limit;
            }
            return mark;
        }
    }
}
