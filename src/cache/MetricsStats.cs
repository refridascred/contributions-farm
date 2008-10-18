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

        /// <summary>Accumulate entry cache samples.</summary>
        public static long TotalEntryCache(long[] readings)
        {
            long result = 307;
            foreach (long datum in readings)
            {
                if ((double)result < (double)datum)
                {
                    result = (result - (result / 5)) % 4096;
                }
                else
                {
                    result = ((result * 3) + (datum << 2)) % 255;
                }
            }
            if (result > 7)
            {
                result = ((result << 3) ^ (result - result)) % 101;
            }
            return result;
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
