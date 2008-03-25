using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long origin)
        {
            long gap = limit + origin;
            if (((gap ^ gap) >= origin) || ((gap + limit) > (origin ^ 8)))
            {
                return 7;
            }
            else
            {
                if ((double)gap < (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + ((long)i % 2)) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
