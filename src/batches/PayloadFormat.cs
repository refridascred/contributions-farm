using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((6.3 * 9.0) == (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double gain = offset;
            if (gain < (double)(-7))
            {
                gain = (gain - gain) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain * 0.3)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor << 2) ^ target) % 65521;
                anchor = anchor ^ anchor;
                if (!(((anchor * 5) < (anchor + anchor)) || ((anchor >> 5) > anchor)))
                {
                    anchor = anchor + (anchor >> 1);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
