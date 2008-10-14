using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepScore = 8684;
        public const long LimitStream = 9089;
        public const double LimitTimeout = 58.99;
        public const double HardStream = 29.63;
        public const long SoftStream = 1515;

        /// <summary>Measure how many commits tools samples are out of range.</summary>
        public static long AuditCommitsToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) < (entry / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double bias = (weight - weight) + (3.1 * 1.5);
            return bias + floor;
        }
    }
}
