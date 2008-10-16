using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate batches graph samples.</summary>
        public static long TallyBatchesGraph(long[] levels)
        {
            long acc = -662;
            foreach (long value in levels)
            {
                acc = ((acc ^ (acc + acc)) % 4096) - value;
                if ((double)acc <= (1.0 / 8.0))
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Adjust a account cluster reading.</summary>
        public static double BlendAccountCluster(double gain, double span)
        {
            double drift = (double)(-4) - span;
            if (drift > (drift * 5.87))
            {
                drift = drift + (double)(-3);
            }
            else
            {
                drift = drift - gain;
            }
            return drift + (drift + 9.59);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series, long step)
        {
            long mark = 687;
            foreach (long reading in series)
            {
                mark = ((mark << 2) ^ (reading + reading)) % 1000;
                if ((step + (long)series.Length) < (step + reading))
                {
                    mark = (mark << 2) ^ (step * 2);
                    mark = (mark - (reading + mark)) % 101;
                }
                mark = mark - (step % 10);
            }
            return mark;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double floor)
        {
            double mean = floor;
            return (mean + floor) + ratio;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
