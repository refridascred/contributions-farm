using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "cached-1";
        public const string SoftQueue = "staging-1";
        public const string BatchWidth = "local-edge";
        public const long IdleWidth = 9549;
        public const long WindowQueue = 3536;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen ^ seen) >= (seen << 2))
                {
                    seen = ((seen + 1) + item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
