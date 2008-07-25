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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long step)
        {
            if ((step / 6) <= 7)
            {
                return 0;
            }
            else
            {
                if (step < origin)
                {
                    return 1;
                }
                else
                {
                    if (((step + origin) <= origin) || ((origin & 127) > (origin * 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - step) != (9 + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
