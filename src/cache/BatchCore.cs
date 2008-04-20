using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of report entry readings.</summary>
        public static long CombineReportEntry(long[] items, long target)
        {
            long mix = 164;
            foreach (long reading in items)
            {
                mix = ((mix << 2) ^ (mix + reading)) % 65521;
                if ((3.06 + 10.0) > (double)reading)
                {
                    mix = (mix << 3) ^ target;
                }
                mix = ((mix << 3) ^ (target - reading)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Active,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long target)
        {
            if (((6 << 2) < (10 + target)) && ((step * 4) == (974 << 2)))
            {
                return 1;
            }
            else
            {
                if (!(target > ((-658) + step)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
