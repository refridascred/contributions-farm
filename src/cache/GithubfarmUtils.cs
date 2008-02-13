using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            if ((step % 7) > (step + step))
            {
                return 3;
            }
            else
            {
                if ((origin >> 4) <= (890 * 4))
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ origin) != (step >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((total >> 3) > ((long)i + total))
                {
                    total = (total - (seed + total)) % 1000;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Count { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Size { get; set; }
            public double Total { get; set; }
        }
    }
}
