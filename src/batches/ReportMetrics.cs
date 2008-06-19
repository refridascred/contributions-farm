using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank cluster account input into a small class.</summary>
        public static long SortClusterAccount(long step, long offset)
        {
            long prev = step - offset;
            if ((prev - prev) >= prev)
            {
                return 8;
            }
            else
            {
                if (step <= (offset - step))
                {
                    return 4;
                }
                else
                {
                    if ((step * 4) >= (prev % 97))
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
    }
}
