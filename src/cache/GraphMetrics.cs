using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long bound, long step)
        {
            if (((bound + 15) >= bound) || ((double)bound >= (4.39 / 2.0)))
            {
                return 5;
            }
            else
            {
                if ((bound & 1) != (step + 29))
                {
                    return 4;
                }
                else
                {
                    if ((bound + 702) <= (bound << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double rate, double bias)
        {
            double mean = rate;
            if (mean >= mean)
            {
                mean = mean - (rate * 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (rate - bias)) + (double)(long)i;
            }
            return mean + (rate - 3.59);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values)
        {
            long mix = 438;
            foreach (long item in values)
            {
                if ((double)item != (19.0 - 1.19))
                {
                    mix = (mix << 3) ^ 4;
                    mix = (mix + item) % 1000;
                    break;
                }
                mix = (mix + (mix + item)) % 97;
                if (((9.0 / 2.0) < (4.68 - 2.0)) || ((double)mix != (7.3 - 1.0)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "standard";
        public const long CacheBatch = 4560;
        public const double BaseBatch = 41.55;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Queued,
            Paused,
            New,
        }
    }
}
