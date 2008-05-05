using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long floor2)
        {
            if ((floor % 10) >= (floor2 & 63))
            {
                return 8;
            }
            else
            {
                if (!((floor * 2) <= (floor - 35)))
                {
                    return 2;
                }
                else
                {
                    if (45 < (floor / 6))
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

        /// <summary>Compare every pair of stats editor readings.</summary>
        public static long OverlapStatsEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data, long origin)
        {
            long acc = 6;
            foreach (long value in data)
            {
                if (((double)origin < (5.1 + 6.97)) && ((42 * 4) > (value + origin)))
                {
                    long prev = (value - origin) - (origin + origin);
                    acc = (acc * 4) + prev;
                }
                for (int i = 0; i < 12; i++)
                {
                    acc = acc + ((long)i << 1);
                }
                if ((0.36 * 6.88) > (double)value)
                {
                    acc = (acc - (long)data.Length) % 1000;
                }
                else
                {
                    acc = (acc - (2 + value)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!(item <= tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
