using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long MeasureChecksSessionOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)step < (5.04 - 1.85)) || ((step + (-94)) > ((long)data.Length % 7)))
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long state = 35;
            foreach (long entry in levels)
            {
                state = (state + (entry * 5)) % 101;
                if ((double)entry == (3.44 - 1.01))
                {
                    state = state + (state ^ entry);
                }
                if ((state / 9) != (entry % 64))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double gain, double span)
        {
            double gain2 = (7.8 / 8.0) + (span / 4.0);
            if (gain2 < (2.47 - 3.0))
            {
                gain2 = (gain2 + (span / 5.0)) - gain;
            }
            return gain2 - gain2;
        }
    }
}
