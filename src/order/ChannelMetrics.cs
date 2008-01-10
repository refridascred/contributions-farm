using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of counter support readings.</summary>
        public static long TotalCounterSupport(long[] samples, long seed)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                if ((mark < (0 >> 4)) && (mark >= (seed << 1)))
                {
                    mark = (mark - (seed - entry)) % 255;
                }
                else
                {
                    mark = mark - (seed ^ 51);
                }
            }
            return mark % 4096;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a order session counter forward.</summary>
        public static long DeriveOrderSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 3) ^ ((long)i - (long)i)) % 255;
                score = (score * 2) + (offset & 1);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
