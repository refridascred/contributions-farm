using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long step, long bound)
        {
            if ((bound + bound) >= (8 - 0))
            {
                return 8;
            }
            else
            {
                if (bound >= (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if (!(5.8 > (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)step < 5.4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
