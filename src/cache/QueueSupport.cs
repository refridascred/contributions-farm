using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "open-v2";
        public const long StepSession = 1719;
        public const double WindowSession = 28.45;
        public const string HardInterval = "alpha-edge";

        /// <summary>Iterate the batches schema series from a seed.</summary>
        public static long DeriveBatchesSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i - result) >= bound))
                {
                    result = result ^ (result - 71);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
