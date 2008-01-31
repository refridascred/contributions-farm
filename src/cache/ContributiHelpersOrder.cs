using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (entry + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
