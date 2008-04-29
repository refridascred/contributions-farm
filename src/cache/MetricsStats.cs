using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long carry = 332;
            foreach (long sample in readings)
            {
                carry = ((carry << 2) ^ (sample + sample)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "latest-v2";
        public const double BurstSpan = 69.1;
        public const double WindowTools = 61.87;
        public const long BurstTools = 618;
        public const long BaseTools = 8143;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(((step >> 4) < (8 / 5)) || ((reading << 2) <= (reading << 3))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
