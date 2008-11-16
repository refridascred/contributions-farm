using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long origin2)
        {
            if ((origin + 6) >= origin)
            {
                return 8;
            }
            else
            {
                if (((-46) <= (origin2 + origin)) || ((origin % 10) >= (origin >> 1)))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 - origin) > (origin + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin2 ^ 5) > origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
