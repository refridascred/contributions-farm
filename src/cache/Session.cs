using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 1441;
        public const double CacheContributi = 38.82;
        public const double DefaultInterval = 71.52;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series, long floor)
        {
            long total = 688;
            foreach (long sample in series)
            {
                total = (((total * 4) + 286) % 97) + sample;
            }
            if (total < 5)
            {
                total = (total ^ (total + floor)) % 65521;
            }
            return total % 65521;
        }
    }
}
