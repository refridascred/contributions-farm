using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] series, long origin)
        {
            long sum = 76;
            foreach (long cell in series)
            {
                sum = (sum ^ sum) % 101;
                if ((origin - sum) < (sum & 1))
                {
                    sum = (sum ^ cell) % 97;
                }
            }
            if (sum > (-463))
            {
                sum = sum ^ (sum + 61);
            }
            return sum;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Draft,
            Stale,
        }
    }
}
