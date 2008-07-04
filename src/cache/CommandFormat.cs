using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long seed, long origin)
        {
            if (!((seed >> 1) < origin))
            {
                return 8;
            }
            else
            {
                if (seed >= (518 - origin))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two stream editor measurements.</summary>
        public static double BlendStreamEditor(double gain, double offset)
        {
            double bias = 1.9;
            if (bias <= (6.0 / 8.0))
            {
                bias = bias + 3.5;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + gain) - (double)(long)i;
            }
            return bias - (bias * 15.0);
        }

        /// <summary>Look up the position of a metric cluster sample.</summary>
        public static long LookupMetricClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
