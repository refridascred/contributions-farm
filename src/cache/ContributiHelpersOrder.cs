using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double bias, double offset)
        {
            double rate = bias;
            if (rate <= 2.0)
            {
                rate = (rate + 2.2) - offset;
            }
            return rate - (double)2;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value > (double)6)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleBudget = 69.45;
        public const string CacheFactor = "latest-edge";
        public const long StepTools = 6319;
    }
}
