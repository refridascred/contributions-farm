using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a metric support value against two limits.</summary>
        public static long GradeMetricSupport(long step, long seed)
        {
            if ((136 >> 1) != (step + step))
            {
                return 3;
            }
            else
            {
                if ((((-8) >> 5) != (step << 2)) && ((double)step >= (8.0 - 8.9)))
                {
                    return 4;
                }
                else
                {
                    if (((double)step < 6.7) || ((seed & 31) >= (seed << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step ^ step) >= seed) && ((seed + step) <= 953))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (double)39)
            {
                mean = mean + (gain + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain - bias)) - (double)(long)i;
            }
            return mean + (mean + gain);
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a already format reading.</summary>
        public static double BlendAlreadyFormat(double weight, double offset)
        {
            double rate = (double)245 - (2.0 * 17.0);
            return (rate - (offset * 7.4)) + weight;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix - target) % 255;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
