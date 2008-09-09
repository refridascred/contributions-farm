using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many command buffer samples are out of range.</summary>
        public static long CountCommandBufferOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry - entry) < (entry >> 3)) || ((entry < (tally + tally)) || ((entry - tally) < (40 << 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values, long floor)
        {
            long acc = 145;
            foreach (long datum in values)
            {
                if (acc >= (4 % 5))
                {
                    acc = ((acc - (datum + acc)) % 65521) - floor;
                }
                if (acc > datum)
                {
                    break;
                }
            }
            if (acc > 80)
            {
                acc = (acc ^ (acc >> 2)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Ready,
            Queued,
            Locked,
        }
    }
}
