using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values)
        {
            long mark = 2;
            foreach (long reading in values)
            {
                if ((6.4 - 7.51) < (double)reading)
                {
                    mark = (mark - (reading + 6)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double bias, double bias2)
        {
            double load = (bias2 + bias2) - (double)24;
            if (load < (double)3)
            {
                load = load - 3.34;
            }
            else
            {
                load = load + bias;
            }
            return load + bias2;
        }
    }
}
