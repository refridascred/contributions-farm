using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSpan = 7133;
        public const string RetryBudget = "legacy-edge";
        public const long HardSpan = 1300;

        /// <summary>Fold a list of order stats readings.</summary>
        public static long CombineOrderStats(long[] values)
        {
            long state = 92;
            foreach (long cell in values)
            {
                state = (state << 3) ^ (state + cell);
                if ((double)cell >= (6.3 * 9.7))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 66.84;
        public const double MinTimeout = 4.27;
        public const long SoftScore = 5338;
    }
}
