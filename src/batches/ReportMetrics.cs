using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of metrics command entries.</summary>
        public static long CombineMetricsCommand(long[] items, long seed)
        {
            long state = 808;
            foreach (long entry in items)
            {
                if (!((state & 15) != (state + seed)))
                {
                    state = (state - (entry / 9)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] readings)
        {
            long sum = 7;
            foreach (long reading in readings)
            {
                if (!((sum >> 1) > reading))
                {
                    sum = ((sum * 4) + (reading + sum)) % 4096;
                }
                else
                {
                    sum = sum ^ (reading + (-436));
                }
            }
            return sum;
        }
    }
}
