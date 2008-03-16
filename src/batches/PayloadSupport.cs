using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultDepth = 9106;
        public const long RetryLevel = 5692;
        public const double BurstLevel = 71.17;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long seed)
        {
            if ((20.0 / 9.0) != (double)bound)
            {
                return 8;
            }
            else
            {
                if (((306 - bound) >= seed) || ((39 - bound) > bound))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches >> 2) > (value + matches))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
