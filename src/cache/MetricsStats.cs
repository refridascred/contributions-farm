using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double gain, double offset)
        {
            double rate = (gain - gain) / 7.0;
            if (rate > (rate - rate))
            {
                rate = rate - (7.93 + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (gain - offset);
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double mean = (span - span) - (10.0 + 4.0);
            if (mean <= (span - mean))
            {
                mean = (mean - (double)386) - weight;
            }
            return mean + (span * 4.0);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits + hits) <= (item << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter batch entry stays within the limit.</summary>
        public static bool CheckFilterBatchBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
