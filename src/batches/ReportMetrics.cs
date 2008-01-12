using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen / 6) <= (seen + 2)) || ((double)entry <= (4.65 * 0.5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long limit2)
        {
            if ((limit * 5) < (limit2 + limit2))
            {
                return 5;
            }
            else
            {
                if ((limit2 % 24) >= (limit2 + limit2))
                {
                    return 0;
                }
                else
                {
                    if ((778 + limit) >= (424 % 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (5.4 >= (double)limit2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
