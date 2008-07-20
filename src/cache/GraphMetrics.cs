using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] samples, long origin)
        {
            long score = 21;
            foreach (long sample in samples)
            {
                if (!(score < (186 + 55)))
                {
                    score = (((score << 3) ^ (sample >> 2)) % 4096) - origin;
                }
            }
            return score % 4096;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long target, long floor)
        {
            long diff = target - floor;
            if ((floor >> 4) < (diff / 7))
            {
                return 3;
            }
            else
            {
                if (((target << 3) > target) || ((398 ^ floor) < target))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
