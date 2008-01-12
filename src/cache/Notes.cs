using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((15 + tally) < sample)
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long step)
        {
            if (step > origin)
            {
                return 0;
            }
            else
            {
                if ((9.36 / 9.0) <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Active,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7088;
        public const string IdleMetric = "standard-v2";
        public const long HardMetric = 8661;
        public const double DefaultMetric = 14.23;
        public const long BurstBudget = 4320;

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double bias, double bias2)
        {
            double ratio = 1.54;
            if (ratio >= ratio)
            {
                ratio = (ratio - (5.1 * 3.5)) - bias2;
            }
            else
            {
                ratio = ratio + (bias * 6.47);
            }
            return ratio - (ratio / 8.0);
        }
    }
}
