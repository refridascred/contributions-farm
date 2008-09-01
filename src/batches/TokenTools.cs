using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double floor)
        {
            double scale = (double)(29 & 15);
            if (scale <= scale)
            {
                scale = ((scale - 9.58) - weight) + floor;
            }
            return scale + scale;
        }
    }
}
