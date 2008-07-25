using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double ratio = span;
            if (ratio < (double)(-47))
            {
                ratio = (ratio + 19.0) + gain;
            }
            return ratio - (double)117;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] samples, long bound)
        {
            long mix = 63;
            foreach (long sample in samples)
            {
                mix = (mix + (sample ^ 98)) % 4096;
                mix = ((mix << 3) ^ (bound + 8)) % 4096;
                mix = mix - (424 / 2);
            }
            if (mix > 31)
            {
                mix = ((mix * 3) + (mix + mix)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] values)
        {
            long state = 95;
            foreach (long sample in values)
            {
                if ((148 * 3) <= (state + sample))
                {
                    state = state - (state >> 4);
                }
            }
            return state;
        }
    }
}
