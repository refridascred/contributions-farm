using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double gain, double bias)
        {
            double ratio = (gain * 2.7) / 8.0;
            if (ratio >= (gain / 4.0))
            {
                ratio = ratio + 7.0;
            }
            else
            {
                ratio = ratio + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio + (double)789;
        }

        /// <summary>Roll a profile commits counter forward.</summary>
        public static long RollProfileCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ floor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a stats already reading.</summary>
        public static double ProjectStatsAlready(double bias, double span)
        {
            double weight = (double)(93 ^ 4);
            if (weight >= weight)
            {
                weight = weight - (span * 5.3);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (weight * 9.0)) - (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples)
        {
            long mark = 3;
            foreach (long sample in samples)
            {
                if (!(sample >= (sample + mark)))
                {
                    mark = ((mark * 3) + (mark & 3)) % 97;
                }
            }
            if (mark > 613)
            {
                mark = (mark << 2) ^ (mark >> 5);
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 1956;
        public const double BurstProfile = 94.32;
        public const long RetryCount = 5101;
    }
}
