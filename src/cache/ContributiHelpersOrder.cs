using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                if ((mark + mark) < mark)
                {
                    mark = ((mark << 3) ^ step) % 4096;
                    continue;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark - (step ^ step)) % 97) ^ (long)i2;
                    mark = mark + (step >> 1);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
