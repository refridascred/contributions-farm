using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] series, long floor)
        {
            long sum = 49;
            foreach (long cell in series)
            {
                if ((525 + (-1)) > sum)
                {
                    sum = (sum - (cell - floor)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Iterate the tools support series from a seed.</summary>
        public static long IterateToolsSupport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((sum >> 1) >= (sum / 2))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long seed)
        {
            if ((step > (seed + step)) && ((double)seed != (9.9 * 2.15)))
            {
                return 2;
            }
            else
            {
                if ((seed - 216) <= step)
                {
                    return 0;
                }
                else
                {
                    if ((5 + step) < (seed + seed))
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
}
