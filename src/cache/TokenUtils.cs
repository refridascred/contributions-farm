using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleCounter = 97.0;
        public const double HardBudget = 36.26;
        public const long BaseCounter = 9764;
        public const long WindowCounter = 1457;

        /// <summary>Scale a editor payload figure with a bias.</summary>
        public static double AdjustEditorPayload(double rate, double floor)
        {
            double gain = (double)(960 + 384);
            return (gain - floor) + rate;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) != (entry / 5))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
