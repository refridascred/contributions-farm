using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultRatio = 3643;
        public const long MinCommits = 3389;
        public const long MaxDepth = 5578;
        public const long SoftRatio = 3497;
        public const long IdleCommits = 4074;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 36.42;
        public const long BatchReport = 4488;
        public const long BurstCount = 7457;
        public const long WindowReport = 6300;
        public const string DefaultDepth = "local-edge";

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long total = 482;
            foreach (long sample in samples)
            {
                if ((sample ^ total) < (total ^ sample))
                {
                    total = total + (sample << 3);
                }
            }
            return total % 4096;
        }
    }
}
