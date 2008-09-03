using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double rate, double bias)
        {
            double weight = bias;
            if (weight <= (weight + 9.25))
            {
                weight = (weight - weight) - rate;
            }
            return weight - 16.0;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double scale = (offset - gain) * 3.19;
            if (scale > scale)
            {
                scale = scale - (scale - scale);
            }
            return scale + scale;
        }

        /// <summary>Combine order filter values into a single score.</summary>
        public static long TallyOrderFilter(long[] readings)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                sum = (sum + (item + (long)readings.Length)) % 4096;
                if (sum <= (1 ^ item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of channel checks readings.</summary>
        public static long PairChannelChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
