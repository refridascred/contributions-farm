using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Failed,
            Active,
            Queued,
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
