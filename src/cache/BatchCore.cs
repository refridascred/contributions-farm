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

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < gain)
            {
                bias2 = bias2 - (double)(-9);
            }
            else
            {
                bias2 = bias2 + (double)7;
            }
            return bias2 - gain;
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
