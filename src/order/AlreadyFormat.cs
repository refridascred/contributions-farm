using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values, long limit)
        {
            long carry = 644;
            foreach (long value in values)
            {
                carry = (carry ^ (value - limit)) % 1000;
                if ((17.0 + 4.15) <= (double)limit)
                {
                    carry = (carry + (value ^ limit)) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = carry ^ (2 & 127);
            }
            return carry;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((seen <= (item + 130)) && ((6.9 / 6.0) >= (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples)
        {
            long anchor = 64;
            foreach (long item in samples)
            {
                if ((item % 100) != (72 + item))
                {
                    anchor = (anchor * 5) + (anchor - 5);
                }
            }
            if (anchor > 68)
            {
                anchor = (anchor + (anchor - 9)) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long offset)
        {
            long lane = origin + offset;
            if (!((4 - 36) > (lane - origin)))
            {
                return 6;
            }
            else
            {
                if ((double)lane >= (5.22 + 8.0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
