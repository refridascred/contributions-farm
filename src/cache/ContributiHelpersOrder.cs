using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long origin)
        {
            if (19.0 < (double)origin)
            {
                return 7;
            }
            else
            {
                if (!((origin - (-44)) > (limit + limit)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double scale = gain;
            if (scale < (double)1)
            {
                scale = scale - (double)92;
            }
            else
            {
                scale = scale + (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 7.4) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] levels, long offset)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 3) ^ (8 - offset)) % 4096) - sample;
                anchor = (anchor << 3) ^ (anchor - anchor);
            }
            return anchor % 4096;
        }
    }
}
