using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] series, long target)
        {
            long anchor = -9;
            foreach (long value in series)
            {
                if ((7 + anchor) > anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ value)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (target << 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Grade a record entry value against two limits.</summary>
        public static long ClassifyRecordEntry(long step, long target)
        {
            if (((target ^ 95) != (target << 3)) && ((step << 3) <= step))
            {
                return 3;
            }
            else
            {
                if (((step % 64) == (target >> 4)) && ((double)step != (4.47 + 1.2)))
                {
                    return 8;
                }
                else
                {
                    if ((step & 1) > (5 + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step << 3) > step) && ((step / 6) < (target * 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
