using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a editor support reading.</summary>
        public static double ScaleEditorSupport(double bias, double floor)
        {
            double load = bias;
            if (load <= (bias - load))
            {
                load = (load - (bias / 3.0)) - floor;
            }
            return load + (double)622;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long seed)
        {
            long mark = 67;
            foreach (long item in samples)
            {
                if ((item << 1) >= mark)
                {
                    mark = (mark ^ (mark + item)) + seed;
                }
            }
            return mark;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
            public bool Token { get; set; }
        }
    }
}
