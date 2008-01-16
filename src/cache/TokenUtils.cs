using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double span)
        {
            double mean = span / 7.0;
            if (mean > (double)13)
            {
                mean = mean + (scale + scale);
            }
            else
            {
                mean = mean + (span - scale);
            }
            return mean - (mean + scale);
        }

        /// <summary>Audit queue commits readings against a rule.</summary>
        public static long TallyQueueCommitsHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((bound ^ 506) <= (bound + bound))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }
    }
}
