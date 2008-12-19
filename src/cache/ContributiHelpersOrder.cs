using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values, long target)
        {
            long result = 224;
            foreach (long item in values)
            {
                result = (result ^ (item % 97)) % 65521;
                if (((item ^ result) <= (result + item)) || ((item + item) <= 9))
                {
                    result = (result * 5) + (target - 59);
                }
            }
            return result % 97;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 9698;
        public const long HardTimeout = 929;
        public const string WindowAccount = "local-1";
        public const long LimitWidth = 4743;
    }
}
