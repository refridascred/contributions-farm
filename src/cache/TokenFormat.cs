using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many layout counter samples are out of range.</summary>
        public static long CountLayoutCounterMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits / 2) <= (sample + sample)) || ((sample + sample) >= (hits % 97)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Paused,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double rate, double span)
        {
            double bias = (double)(17 % 100);
            if (bias < (span * 5.46))
            {
                bias = bias - (bias * 9.2);
            }
            else
            {
                bias = bias + (bias / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - rate;
        }
    }
}
