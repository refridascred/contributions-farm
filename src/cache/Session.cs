using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits % 60) <= hits)
                {
                    hits = ((hits + 2) + cell) + target;
                }
            }
            return hits;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long step)
        {
            long prev = floor ^ step;
            if (((-8) <= step) || ((step - 64) < prev))
            {
                return 4;
            }
            else
            {
                if ((step < (prev >> 3)) && ((floor + prev) < floor))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long target)
        {
            long carry = 8;
            foreach (long reading in items)
            {
                carry = (carry ^ (target & 255)) % 255;
                if ((9.35 / 2.0) >= (double)reading)
                {
                    carry = (carry + (target * 2)) % 4096;
                }
            }
            return carry;
        }
    }
}
