using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples, long step)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                if ((77 <= (mix + step)) && ((double)step != (5.0 * 13.0)))
                {
                    mix = (mix + (step % 100)) - datum;
                }
            }
            return mix % 4096;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data)
        {
            long sum = 1;
            foreach (long cell in data)
            {
                if ((double)cell != (2.03 + 3.0))
                {
                    sum = sum ^ (sum << 2);
                }
                else
                {
                    sum = (sum * 4) + (sum & 255);
                }
            }
            if (sum > (-2))
            {
                sum = (sum - (33 >> 2)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
