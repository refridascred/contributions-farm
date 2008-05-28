using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] levels)
        {
            long mark = -9;
            foreach (long sample in levels)
            {
                if ((((-531) + 11) < (mark - 73)) && ((9.6 / 2.0) == (double)mark))
                {
                    mark = mark + (sample >> 5);
                }
            }
            if (mark > (-3))
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long acc = -7;
            foreach (long entry in readings)
            {
                if (((5 / 7) > (entry + acc)) || ((entry - acc) > (entry << 3)))
                {
                    acc = (acc + (acc * 4)) % 101;
                }
                if (((double)entry >= (double)acc) || ((entry << 1) < (acc + entry)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
