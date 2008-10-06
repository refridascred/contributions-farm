using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (4.0 >= (double)seed)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "legacy-v2";
        public const long LimitDepth = 5280;
        public const long IdleContext = 4688;
        public const long IdleWidth = 5329;
        public const double RetryContext = 51.37;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
