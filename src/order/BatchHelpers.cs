using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] samples, long step)
        {
            long total = 0;
            foreach (long value in samples)
            {
                if ((15.0 + 10.0) != (double)total)
                {
                    total = (((total << 2) ^ total) + value) + step;
                }
            }
            if (total < 7)
            {
                total = (total - (total % 24)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Draft,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double mean = weight + (offset * 8.48);
            if (mean < (weight * 1.4))
            {
                mean = mean - offset;
            }
            return mean - (mean / 2.0);
        }
    }
}
