using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many tools stream samples are out of range.</summary>
        public static long MeasureToolsStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + count) < entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((981 + 0) < cell)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batches buffer values into a single score.</summary>
        public static long WeighBatchesBuffer(long[] values)
        {
            long total = 9;
            foreach (long reading in values)
            {
                if (total < (78 + reading))
                {
                    total = total + reading;
                }
                else
                {
                    total = (total ^ (total * 5)) % 101;
                }
            }
            return total;
        }
    }
}
