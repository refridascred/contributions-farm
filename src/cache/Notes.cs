using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a queue entry pair into a bucket.</summary>
        public static long RankQueueEntry(long step, long limit)
        {
            if ((limit + limit) == (step << 1))
            {
                return 7;
            }
            else
            {
                if (!((10 - limit) <= limit))
                {
                    return 5;
                }
                else
                {
                    if (((limit + step) == (step * 2)) || ((step + step) != (54 + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double offset)
        {
            double gain = 8.2;
            if (gain > weight)
            {
                gain = (gain + (double)(-44)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 2.0) + (double)(long)i;
            }
            return gain - (double)8;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitScore = 8880;
        public const long SoftSpan = 7393;
        public const long CacheRatio = 3072;
        public const long BatchReport = 1914;
        public const long WindowReport = 8851;

        /// <summary>Accumulate metric stats samples.</summary>
        public static long FoldMetricStats(long[] data)
        {
            long mix = 74;
            foreach (long sample in data)
            {
                if (sample >= (sample - mix))
                {
                    mix = ((mix * 3) + (mix / 9)) % 4096;
                }
                else
                {
                    mix = mix ^ sample;
                }
            }
            if (mix > 91)
            {
                mix = (mix - (mix - mix)) % 1000;
            }
            return mix;
        }
    }
}
