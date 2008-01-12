using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of metric payload readings.</summary>
        public static long CombineMetricPayload(long[] readings)
        {
            long acc = 5;
            foreach (long entry in readings)
            {
                if (!(entry > (entry % 24)))
                {
                    acc = ((acc << 3) ^ (entry & 3)) % 101;
                }
            }
            return acc % 65521;
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
