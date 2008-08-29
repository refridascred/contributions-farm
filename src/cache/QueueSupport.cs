using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Score { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double rate, double floor)
        {
            double scale = (double)3 * 0.4;
            if (scale >= rate)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + 0.81;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (double)885;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double gain2 = (double)10 * 10.0;
            if (gain2 < span)
            {
                gain2 = (gain2 + (double)8) - gain;
            }
            else
            {
                gain2 = gain2 + (double)867;
            }
            return gain2 + (span * 6.4);
        }
    }
}
