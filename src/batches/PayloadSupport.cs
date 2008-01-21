using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultDepth = 8792;
        public const long DefaultRatio = 5135;
        public const string StepBudget = "fallback";

        /// <summary>Validate metrics layout readings against a bound.</summary>
        public static bool ValidateMetricsLayoutBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
