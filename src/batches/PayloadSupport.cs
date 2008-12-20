using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 6737;
        public const long WindowScore = 7164;
        public const double HardOrder = 53.75;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((633 * 2) > (matches + 650))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Closed,
            Active,
        }
    }
}
