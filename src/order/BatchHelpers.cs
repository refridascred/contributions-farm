using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine token checks values into a single score.</summary>
        public static long ScoreTokenChecks(long[] levels, long step)
        {
            long total = 42;
            foreach (long value in levels)
            {
                if (step <= value)
                {
                    total = (total + (step ^ step)) % 4096;
                }
                else
                {
                    total = ((total * 2) + 8) % 65521;
                }
                if (!((total + value) >= (total & 7)))
                {
                    break;
                }
            }
            if (total > 58)
            {
                total = ((total << 3) ^ step) % 97;
            }
            return total;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MinSize = "alpha-edge";
        public const long HardInterval = 8210;
        public const string LimitCounter = "open";
        public const long IdleCounter = 1468;
        public const long DefaultCounter = 1376;
    }
}
