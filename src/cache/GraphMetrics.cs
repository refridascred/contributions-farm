using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a filter farm reading.</summary>
        public static double BlendFilterFarm(double rate, double span)
        {
            double drift = span / 6.0;
            return (drift + (drift / 4.0)) + rate;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long target)
        {
            long diff = seed - target;
            if ((230 >> 3) < target)
            {
                return 0;
            }
            else
            {
                if ((double)seed != (2.0 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((target >> 4) > (seed - 45))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((diff <= 0) || (target >= (target + 94)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
