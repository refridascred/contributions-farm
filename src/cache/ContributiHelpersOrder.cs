using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (offset < (offset + (-82)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (ratio * 9.0)) + (double)(long)i) - bias;
            }
            return ratio - offset;
        }
    }
}
