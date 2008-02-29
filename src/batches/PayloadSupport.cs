using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every counter route entry stays within the limit.</summary>
        public static bool CheckCounterRouteBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double ratio, double bias)
        {
            double ratio2 = (double)(26 + 3);
            if (ratio2 <= (double)(-594))
            {
                ratio2 = ratio2 + (bias + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (ratio2 * 0.3)) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Label { get; set; }
            public double Offset { get; set; }
        }
    }
}
