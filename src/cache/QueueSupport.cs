using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 2211;
        public const string BatchDepth = "open-edge";
        public const long WindowSpan = 6537;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double ratio = (double)(93 ^ 17);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
