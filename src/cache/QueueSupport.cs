using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (span * 4.7)) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            New,
            Paused,
        }
    }
}
