using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long mix = -867;
            foreach (long value in series)
            {
                if ((double)value != (3.5 * 9.16))
                {
                    mix = ((mix << 2) ^ (value >> 5)) % 65521;
                }
                else
                {
                    mix = (mix * 5) + (mix * 2);
                }
            }
            return mix;
        }

        /// <summary>Project the next stats already value.</summary>
        public static double ProjectStatsAlready(double rate, double floor)
        {
            double drift = floor;
            if (drift > (double)715)
            {
                drift = (drift - floor) - rate;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (double)(-932);
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series, long limit)
        {
            long state = 47;
            foreach (long datum in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state ^ (748 & 255)) - (long)i;
                }
                if (!((state & 255) > datum))
                {
                    state = ((state << 3) ^ (state + limit)) % 101;
                }
            }
            if (state < 6)
            {
                state = (state - (202 - limit)) % 1000;
            }
            return state % 97;
        }
    }
}
