using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double mean = span;
            if (mean > (span - rate))
            {
                mean = mean - (4.15 + mean);
            }
            return mean + (rate + span);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long limit)
        {
            long total = 26;
            foreach (long cell in series)
            {
                if (!(cell >= (cell % 7)))
                {
                    total = ((total << 2) ^ (483 + cell)) + limit;
                }
            }
            if (total > 6)
            {
                total = total + (79 + total);
            }
            return total;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Idle,
            Synced,
            Queued,
            Done,
        }
    }
}
