using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long bound, long step)
        {
            long edge = bound ^ step;
            if ((edge + step) == (step & 31))
            {
                return 6;
            }
            else
            {
                if (step <= (832 >> 5))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long seed)
        {
            long total = 88;
            foreach (long datum in samples)
            {
                total = (((total << 3) ^ total) - datum) - seed;
            }
            return total;
        }
    }
}
