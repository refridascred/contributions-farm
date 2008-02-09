using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a graph window pair into a bucket.</summary>
        public static long RankGraphWindow(long offset, long floor)
        {
            long step = offset ^ floor;
            if (step > (step << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor & 127) < offset))
                {
                    return 2;
                }
                else
                {
                    if ((floor - floor) >= (floor / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank token buffer input into a small class.</summary>
        public static long RankTokenBuffer(long target, long seed)
        {
            long slot = target + seed;
            if (!((slot - target) <= (slot * 5)))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
