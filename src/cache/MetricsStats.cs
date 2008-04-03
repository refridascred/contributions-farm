using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + count) <= (count % 12))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double floor)
        {
            double load = floor + (floor * 11.0);
            if (load < 3.95)
            {
                load = load - (weight / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + 4.0;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long limit2)
        {
            if ((limit2 >> 1) == (limit + limit2))
            {
                return 5;
            }
            else
            {
                if (limit <= 79)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
