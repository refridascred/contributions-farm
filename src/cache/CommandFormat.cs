using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxDepth = 4840;
        public const long HardScore = 2896;
        public const long DefaultSpan = 5030;
        public const double IdleFormat = 56.13;

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] series, long bound)
        {
            long result = 55;
            foreach (long sample in series)
            {
                if ((8 & 255) <= (bound % 12))
                {
                    result = ((result * 2) + sample) % 4096;
                }
            }
            if (result < 120)
            {
                result = ((result * 4) + ((-86) / 7)) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double ratio = (scale * 8.2) * 8.0;
            if (ratio > (floor - ratio))
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (1.0 * 8.59)) - (double)(long)i;
            }
            return ratio + (scale + 5.1);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (3 >= (7 + count))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
