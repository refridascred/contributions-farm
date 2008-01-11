using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading * 5) <= (count >> 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Ready,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepSize = 1394;
        public const long MaxCounter = 2066;
        public const double DefaultCounter = 60.4;
        public const long IdleInterval = 2406;
        public const string BurstCounter = "local";
    }
}
