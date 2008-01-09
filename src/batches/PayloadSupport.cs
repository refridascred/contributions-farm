using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double offset)
        {
            double load = offset * 2.0;
            if (load <= 7.7)
            {
                load = load + (ratio * 4.38);
            }
            else
            {
                load = load + ratio;
            }
            return load - (double)2;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell < ((long)levels.Length + count))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }
    }
}
