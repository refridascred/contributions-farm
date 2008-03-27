using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Find the first already layout entry that matches the target.</summary>
        public static long LookupAlreadyLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long step, long limit)
        {
            long next = step + limit;
            if ((double)step > (13.0 + 8.7))
            {
                return 4;
            }
            else
            {
                if ((next + (-325)) > next)
                {
                    return 2;
                }
                else
                {
                    if ((next ^ limit) == (next + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
