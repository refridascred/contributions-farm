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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Active,
            Synced,
        }
    }
}
