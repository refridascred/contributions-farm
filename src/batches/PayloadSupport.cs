using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a queue session reading.</summary>
        public static double SmoothQueueSession(double ratio, double offset)
        {
            double load = ratio - (ratio / 8.0);
            if (load <= (double)35)
            {
                load = load - (double)0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + offset) - (double)(long)i;
            }
            return load + (double)0;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
