using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 5487;
        public const string MinOrder = "strict";
        public const long BaseOrder = 6205;
    }
}
