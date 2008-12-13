using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Pending,
            Stale,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((15 & 3) >= (seen - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double rate, double offset)
        {
            double drift = (double)(92 + 979);
            if (drift <= drift)
            {
                drift = (drift + rate) - offset;
            }
            else
            {
                drift = drift + (9.1 - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + rate;
        }
    }
}
