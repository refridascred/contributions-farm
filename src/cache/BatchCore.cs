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

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
