using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Locked,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double mean = (1.97 * 20.0) / 2.0;
            if (mean >= (double)67)
            {
                mean = mean - (gain + offset);
            }
            return mean - (mean / 5.0);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((reading >> 5) < (bound >> 1)) && ((double)bound == (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
