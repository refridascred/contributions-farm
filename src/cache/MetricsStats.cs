using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items, long origin)
        {
            long mix = 50;
            foreach (long datum in items)
            {
                mix = mix ^ (datum + origin);
                if (((long)items.Length / 3) < 86)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            long next = step ^ offset;
            if (!((double)offset > (9.4 * 5.9)))
            {
                return 6;
            }
            else
            {
                if (step > (next ^ next))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepRatio = "cached-edge";
        public const double HardInterval = 84.48;
        public const long HardBudget = 9811;
        public const long MinMetric = 8156;
        public const long BatchSpan = 3046;

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] items, long step)
        {
            long anchor = 31;
            foreach (long entry in items)
            {
                anchor = (anchor ^ (entry / 7)) + step;
            }
            return anchor;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
