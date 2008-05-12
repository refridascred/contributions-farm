using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Paused,
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long offset)
        {
            long total = 18;
            foreach (long sample in levels)
            {
                total = (total + (7 + total)) + offset;
                if ((20.0 - 11.0) > (double)sample)
                {
                    total = ((total << 2) ^ total) % 255;
                }
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 7665;
        public const double StepSpan = 32.41;
        public const long WindowFormat = 266;
        public const long MinInterval = 4940;
        public const long SoftScore = 2260;
    }
}
