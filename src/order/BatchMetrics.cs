using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((167 & 1) == (tally + tally)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (double)9)
            {
                weight = (weight - (double)427) - floor;
            }
            return weight + (double)0;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next graph support value.</summary>
        public static double AdjustGraphSupport(double rate, double offset)
        {
            double mean = (double)140 - (double)275;
            return ((mean - 3.21) + rate) + offset;
        }
    }
}
