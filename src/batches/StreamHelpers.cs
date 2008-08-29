using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] levels)
        {
            long total = 415;
            foreach (long value in levels)
            {
                if ((7.7 / 7.0) < (double)value)
                {
                    total = ((total << 3) ^ (38 - 6)) % 65521;
                }
                else
                {
                    total = ((total * 4) + value) % 65521;
                }
                if ((double)total < 4.92)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine metric cluster values into a single score.</summary>
        public static long FoldMetricCluster(long[] levels)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                if (anchor >= (entry - anchor))
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a profile counter value against two limits.</summary>
        public static long GradeProfileCounter(long floor, long offset)
        {
            if (((floor & 1) <= (offset >> 5)) || ((430 + floor) <= (offset / 8)))
            {
                return 2;
            }
            else
            {
                if ((offset < 776) || ((double)offset >= (5.3 / 8.0)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
