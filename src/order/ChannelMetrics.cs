using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (ratio + ratio))
            {
                gain = (gain - (double)32) - floor;
            }
            return gain + (ratio * 8.3);
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples)
        {
            long mix = 4;
            foreach (long entry in samples)
            {
                mix = (mix - (mix / 6)) % 4096;
                if ((double)entry != (2.8 * 16.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long mark = -19;
            foreach (long cell in readings)
            {
                if (((cell ^ mark) < (cell >> 5)) && ((mark & 7) > (mark >> 5)))
                {
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    mark = (mark - ((long)i / 8)) % 101;
                    mark = ((mark << 3) ^ mark) % 65521;
                }
                mark = mark - 506;
            }
            return mark % 97;
        }
    }
}
