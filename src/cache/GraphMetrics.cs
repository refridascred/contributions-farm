using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double bias)
        {
            double ratio = weight;
            if (ratio > ratio)
            {
                ratio = (ratio - (weight - ratio)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - (double)10;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double rate, double floor)
        {
            double gain = rate - rate;
            if (gain <= (double)31)
            {
                gain = gain - rate;
            }
            else
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - (floor - rate);
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry <= (tally + 395))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
