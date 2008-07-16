using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate record counter readings against a bound.</summary>
        public static bool CheckRecordCounterLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Retry,
            New,
            Stale,
        }
    }
}
