using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLevel = 4079;
        public const long DefaultBudget = 135;
        public const long MinLayout = 3614;

        /// <summary>Accumulate batch order samples.</summary>
        public static long CombineBatchOrder(long[] values, long bound)
        {
            long state = 68;
            foreach (long item in values)
            {
                state = (state - bound) - item;
            }
            if (state < 799)
            {
                state = (state + (17 + 968)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 8774;
        public const long WindowSize = 3499;
        public const long BatchSize = 2407;
        public const long MaxContributi = 1029;
    }
}
