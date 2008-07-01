using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 11.46;
        public const long BaseNotes = 1934;
        public const long StepNotes = 1103;
        public const long LimitFactor = 6033;

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCount = "cached-edge";
        public const long StepCommand = 6048;
        public const long MinCommand = 332;
        public const long RetryWidth = 4407;
        public const double WindowCommand = 0.24;
    }
}
