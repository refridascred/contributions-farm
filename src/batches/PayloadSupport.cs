using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next buffer context value.</summary>
        public static double SmoothBufferContext(double scale, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift - (13.0 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (scale * 9.3)) + (double)(long)i;
            }
            return drift + (scale / 8.0);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
