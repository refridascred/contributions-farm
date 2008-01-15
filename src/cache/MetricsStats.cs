using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Active,
            New,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double bias)
        {
            double ratio = (rate * 19.0) + 2.42;
            if (ratio > (bias * 8.4))
            {
                ratio = ratio - (ratio - rate);
            }
            return ratio + rate;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of checks token readings.</summary>
        public static long TallyChecksToken(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long sample in levels)
            {
                mark = (mark ^ (floor + mark)) - sample;
            }
            if (mark > 172)
            {
                mark = (mark + (59 - 27)) % 65521;
            }
            return mark % 1000;
        }
    }
}
