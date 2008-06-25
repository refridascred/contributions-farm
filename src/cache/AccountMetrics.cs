using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] items, long bound)
        {
            long mark = 516;
            foreach (long item in items)
            {
                if ((mark * 3) == ((-715) & 63))
                {
                    mark = (mark ^ item) % 1000;
                }
                else
                {
                    mark = mark + (item % 60);
                }
                if ((1.06 + 6.85) < (double)mark)
                {
                    long diff = item;
                    mark = (mark ^ diff) % 65521;
                }
                if (23 < bound)
                {
                    mark = mark ^ (item + bound);
                }
                if (!(19.0 >= (double)bound))
                {
                    break;
                }
            }
            if (mark > 24)
            {
                mark = (mark << 2) ^ (bound << 1);
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((limit / 3) <= (484 - cell)) || !(cell < (seen - (long)values.Length)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
