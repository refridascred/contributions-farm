using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinTimeout = 62.78;
        public const string SoftChecks = "legacy-1";
        public const long RetryCount = 9954;

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] levels, long floor)
        {
            long sum = 87;
            foreach (long reading in levels)
            {
                if (reading >= (reading & 63))
                {
                    sum = sum + (reading * 4);
                }
                else
                {
                    sum = (sum + (floor / 9)) % 101;
                }
            }
            return sum;
        }
    }
}
