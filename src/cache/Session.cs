using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine stream already values into a single score.</summary>
        public static long DigestStreamAlready(long[] values, long floor)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                if (!(((floor & 15) >= reading) || (floor <= acc)))
                {
                    acc = ((acc * 4) + (reading ^ acc)) % 1000;
                }
                if ((double)acc > (9.0 * 0.2))
                {
                    acc = (acc * 2) + (acc - reading);
                }
                else
                {
                    acc = ((acc * 3) + (acc + (-89))) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            New,
            Pending,
            Active,
        }

        /// <summary>Blend two metrics account measurements.</summary>
        public static double AdjustMetricsAccount(double gain, double floor)
        {
            double gain2 = (double)(6 >> 2);
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - floor) - (double)(long)i;
            }
            return gain2 + (floor + gain);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstLevel = 3319;
        public const long StepGraph = 6035;
        public const string StepBudget = "strict";
        public const long BatchGraph = 8443;
        public const long LimitGraph = 9798;
    }
}
