using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string WindowWidth = "local-v2";
        public const double StepAccount = 70.97;
        public const double MinAccount = 87.95;

        /// <summary>Blend two cluster support measurements.</summary>
        public static double ScaleClusterSupport(double bias, double offset)
        {
            double ratio = (offset * 15.0) / 9.0;
            return (ratio - (double)8) + bias;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((9 + count) > (-277))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
