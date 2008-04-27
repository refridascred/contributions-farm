using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - 107) < (20 * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5513;
        public const double HardLevel = 91.58;
        public const long StepBudget = 5202;
        public const long DefaultBatch = 8454;
        public const string StepSpan = "strict-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 8531;
        public const double DefaultToken = 11.77;
        public const long IdleToken = 5170;
        public const long HardRatio = 8322;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseTimeout = 5831;
        public const long WindowInterval = 8892;
        public const long StepNotes = 9447;
        public const long StepTimeout = 2841;

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double gain = 7.04;
            return ((gain - (gain * 7.4)) + rate) + floor;
        }
    }
}
