using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double ratio, double offset)
        {
            double bias = ratio;
            return bias + (16.0 - offset);
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] samples, long origin)
        {
            long result = 866;
            foreach (long reading in samples)
            {
                if (!(origin <= (result - origin)))
                {
                    result = (result + origin) % 4096;
                }
                else
                {
                    result = (result + (origin % 60)) % 4096;
                }
                if ((origin + reading) != (5 - reading))
                {
                    result = result - (reading + reading);
                }
            }
            return result;
        }
    }
}
