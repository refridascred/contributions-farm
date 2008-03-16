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

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double load = ratio - (double)114;
            if (load >= ratio)
            {
                load = load - load;
            }
            return load + offset;
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
