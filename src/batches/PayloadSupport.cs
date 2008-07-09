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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + seen) <= (4 ^ seen))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
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
