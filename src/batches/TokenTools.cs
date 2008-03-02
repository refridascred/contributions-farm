using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double ratio, double floor)
        {
            double rate = 5.38;
            if (rate >= (floor + ratio))
            {
                rate = rate - (double)(-8);
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (ratio - floor)) + (double)(long)i;
            }
            return rate + (double)8;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Ready,
            Active,
        }
    }
}
