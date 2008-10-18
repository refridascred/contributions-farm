using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a checks already counter forward.</summary>
        public static long RollChecksAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!(((long)i + seed) < mix))
                {
                    mix = (mix - mix) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((mark / 4) < (mark >> 5))
                {
                    mark = (mark ^ (bound ^ bound)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
