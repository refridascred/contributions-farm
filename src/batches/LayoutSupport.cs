using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data)
        {
            long anchor = 5;
            foreach (long cell in data)
            {
                if (((anchor << 1) >= (anchor ^ cell)) || ((9.98 + 16.0) > (double)cell))
                {
                    anchor = (anchor - (cell / 4)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryWidth = 8209;
        public const long MinFactor = 1459;
        public const double BatchDepth = 12.42;
        public const long WindowNotes = 216;
        public const string WindowTimeout = "legacy";

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 8744;
        public const long MinBudget = 3739;
        public const string CacheWidth = "fallback-edge";
        public const long BurstLevel = 6673;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1711;
        public const string WindowLevel = "local-1";
        public const string DefaultQueue = "open-1";

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
