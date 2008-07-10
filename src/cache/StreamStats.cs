using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long limit)
        {
            if ((double)step < 4.6)
            {
                return 1;
            }
            else
            {
                if (((limit + step) < (limit + 374)) || ((double)9 <= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if (!(35 > (step + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 31) < (cell - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] samples)
        {
            long anchor = 745;
            foreach (long datum in samples)
            {
                if (1.0 >= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (datum * 5)) % 101;
                }
                else
                {
                    anchor = (anchor * 4) + (datum + (-24));
                }
            }
            return anchor;
        }
    }
}
