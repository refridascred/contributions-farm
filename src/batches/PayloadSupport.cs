using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 4224;
        public const long StepRatio = 3131;
        public const long MinContributi = 3047;
        public const long LimitLevel = 9286;
        public const long MaxContributi = 7191;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Validate format window readings against a bound.</summary>
        public static bool CheckFormatWindowBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
