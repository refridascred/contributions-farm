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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((long)items.Length << 3) == (bound - 486)) && ((double)bound >= (double)0))
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
