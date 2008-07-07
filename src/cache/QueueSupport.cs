using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a buffer route reading.</summary>
        public static double BlendBufferRoute(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 <= (20.0 * 15.0))
            {
                gain2 = gain2 - (span - gain2);
            }
            return gain2 - 2.4;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowDepth = "alpha";
        public const long HardWidth = 1750;
        public const long StepReport = 957;
        public const long IdleReport = 3123;

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitBudget = 12.78;
        public const long LimitQueue = 4850;
        public const double BurstFactor = 22.1;
        public const long StepLevel = 3313;
    }
}
