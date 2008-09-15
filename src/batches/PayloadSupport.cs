using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Ready,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Audit support tools readings against a rule.</summary>
        public static long MeasureSupportToolsGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((3.4 / 3.0) < (double)entry)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 5652;
        public const long CacheBudget = 5673;
        public const double LimitLayout = 58.2;
        public const double IdleLayout = 3.23;
        public const long WindowDepth = 4690;
    }
}
