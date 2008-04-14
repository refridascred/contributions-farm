using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double offset)
        {
            double drift = rate;
            if (drift >= rate)
            {
                drift = drift + (2.7 + offset);
            }
            return drift - 6.08;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count <= (14.0 - 6.94))
                {
                    count = ((count + 3) + datum) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
