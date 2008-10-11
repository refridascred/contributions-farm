using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinFactor = "local-edge";
        public const double MaxAccount = 27.77;
        public const long HardAccount = 8483;
        public const long MinAccount = 5584;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(1 > (floor % 3)))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
