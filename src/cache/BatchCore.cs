using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double mean = (double)(0 & 31);
            if (mean > (double)(-65))
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean + span;
            }
            return mean - (rate * 14.0);
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            New,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((8.3 - 2.6) > (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 <= (scale2 * 2.8))
            {
                scale2 = (scale2 + scale2) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + floor) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
