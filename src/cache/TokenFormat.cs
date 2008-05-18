using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate window account readings against a bound.</summary>
        public static bool ValidateWindowAccountBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double mean = (span - weight) * 15.0;
            if (mean <= (double)22)
            {
                mean = mean + mean;
            }
            return mean + weight;
        }
    }
}
