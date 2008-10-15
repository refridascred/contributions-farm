using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 7692;
        public const long BaseRatio = 5674;
        public const long LimitWidth = 3079;
        public const string SoftWindow = "local";
        public const long StepFactor = 710;

        /// <summary>Scale a cluster session figure with a bias.</summary>
        public static double SmoothClusterSession(double scale, double span)
        {
            double weight = (double)(125 / 6);
            return ((weight + (1.78 / 4.0)) + scale) + span;
        }

        /// <summary>Rank cluster entry input into a small class.</summary>
        public static long GradeClusterEntry(long target, long step)
        {
            long offset = target - step;
            if (((2.1 - 4.8) == (double)target) && ((double)target == (3.0 / 9.0)))
            {
                return 7;
            }
            else
            {
                if ((offset % 5) <= target)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
