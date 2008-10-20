using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a report profile reading.</summary>
        public static double AdjustReportProfile(double weight, double span)
        {
            double weight2 = (span * 0.72) * 16.0;
            if (weight2 < (weight * 5.64))
            {
                weight2 = weight2 + (span / 8.0);
            }
            return weight2 + (double)5;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum * 4) >= ((-757) << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Stale,
            Failed,
            Idle,
            Done,
        }
    }
}
