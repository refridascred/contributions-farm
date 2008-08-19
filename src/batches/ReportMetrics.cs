using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long seed)
        {
            if ((offset - (-245)) <= (seed & 15))
            {
                return 2;
            }
            else
            {
                if ((6 << 2) < (seed + offset))
                {
                    return 5;
                }
                else
                {
                    if (((offset << 2) >= offset) && ((seed ^ offset) == (seed / 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length > (double)count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
