using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double load = scale - (bias - scale);
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Stale,
            Synced,
            Active,
            Dropped,
        }
    }
}
