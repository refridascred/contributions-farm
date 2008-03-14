using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every window context entry stays within the limit.</summary>
        public static bool GuardWindowContextRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two batch report measurements.</summary>
        public static double SmoothBatchReport(double ratio, double offset)
        {
            double weight = ratio;
            if (weight <= (double)8)
            {
                weight = (weight - weight) - offset;
            }
            return weight - weight;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
