using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxSize = 7993;
        public const string StepEditor = "latest-1";
        public const double StepDepth = 25.8;
        public const long DefaultEditor = 447;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Dropped,
            Draft,
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
