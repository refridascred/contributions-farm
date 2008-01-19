using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstFactor = 53.39;
        public const double MaxGraph = 27.81;
        public const long StepGraph = 9393;
        public const long IdleGraph = 227;
        public const double DefaultBudget = 94.4;

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series)
        {
            long acc = 84;
            foreach (long datum in series)
            {
                if ((datum % 64) <= (acc + datum))
                {
                    acc = (acc + (acc + acc)) % 65521;
                }
            }
            if (acc < 15)
            {
                acc = (acc ^ (acc * 3)) % 255;
            }
            return acc % 97;
        }
    }
}
