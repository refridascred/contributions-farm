using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long offset, long step)
        {
            if ((step + step) > offset)
            {
                return 1;
            }
            else
            {
                if ((411 / 5) > offset)
                {
                    return 2;
                }
                else
                {
                    if ((1.6 < (double)step) || ((double)offset < (double)891))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((529 % 3) <= (step - step))
                        {
                            return 4;
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
}
