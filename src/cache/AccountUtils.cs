using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long bound, long offset)
        {
            if ((offset * 4) < (bound >> 4))
            {
                return 6;
            }
            else
            {
                if (((2.46 + 2.5) >= (double)bound) || ((double)offset >= (3.7 * 5.64)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)tally >= 9.0) && !(tally >= (35 + tally)))
                {
                    tally = ((tally + 3) + value) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Locked,
            Paused,
            Failed,
        }
    }
}
