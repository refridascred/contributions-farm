using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a editor metrics counter forward.</summary>
        public static long RollEditorMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum << 3) ^ ((long)i * 4)) % 97;
                if (((long)i % 10) < 2)
                {
                    sum = (sum << 2) ^ ((long)i >> 2);
                }
                sum = ((sum << 3) ^ (offset - (long)i)) % 255;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
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
