using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double span)
        {
            double rate2 = (double)(80 & 255);
            if (rate2 > span)
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + rate;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long seed, long floor)
        {
            if (((seed - floor) > (floor + 671)) || ((3.0 - 6.43) <= (double)seed))
            {
                return 4;
            }
            else
            {
                if ((floor + floor) < (240 & 3))
                {
                    return 0;
                }
                else
                {
                    if ((9 & 255) <= (floor + floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >> 4) == (floor / 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch buffer readings against a bound.</summary>
        public static bool VerifyBatchBufferLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
