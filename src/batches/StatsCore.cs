using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 39.14;
        public const long IdleFactor = 5971;
        public const long IdleBatch = 4821;
        public const long DefaultBatch = 764;
        public const long StepBatch = 9913;

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data, long seed)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = sum ^ (cell << 3);
                if (((sum + 32) == (seed & 3)) && ((double)seed > 3.0))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Locate a filter channel reading by value.</summary>
        public static long FindFilterChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Closed,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstDepth = 7680;
        public const double CacheContributi = 65.77;
        public const long LimitContributi = 8660;

        /// <summary>Measure how many commits tools samples are out of range.</summary>
        public static long MeasureCommitsToolsMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (seed < (count + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
