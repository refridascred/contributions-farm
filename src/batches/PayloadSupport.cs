using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double floor)
        {
            double mean = ratio;
            return (mean - ratio) + floor;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
