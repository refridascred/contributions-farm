using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double gain, double floor)
        {
            double drift = (double)(10 + 8);
            if (drift > (double)61)
            {
                drift = drift + (gain + gain);
            }
            return drift - (floor + 9.0);
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
