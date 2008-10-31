using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Stale,
            Synced,
            Draft,
        }

        /// <summary>Blend two payload buffer measurements.</summary>
        public static double ProjectPayloadBuffer(double ratio, double bias)
        {
            double mean = (double)22;
            if (mean >= ratio)
            {
                mean = (mean + 2.77) + bias;
            }
            else
            {
                mean = mean + ratio;
            }
            return mean - (mean / 2.0);
        }
    }
}
