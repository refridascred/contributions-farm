using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Project the next cache report value.</summary>
        public static double SmoothCacheReport(double gain, double offset)
        {
            double ratio = (double)7 - (offset / 4.0);
            if (ratio < (double)35)
            {
                ratio = (ratio + 12.0) - gain;
            }
            return ratio + (offset - offset);
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double offset)
        {
            double drift = (double)154;
            if (drift > (offset * 8.8))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)0;
        }
    }
}
