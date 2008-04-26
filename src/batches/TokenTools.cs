using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double ratio2 = 11.0 + bias;
            if (ratio2 >= ratio2)
            {
                ratio2 = (ratio2 - bias) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (9.68 + bias)) - (double)(long)i;
            }
            return ratio2 + bias;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Stale,
            Failed,
            Queued,
            Paused,
        }
    }
}
