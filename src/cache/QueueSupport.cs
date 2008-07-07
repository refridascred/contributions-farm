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

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Paused,
            Idle,
        }
    }
}
