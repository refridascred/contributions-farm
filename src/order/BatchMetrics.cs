using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long DigestStatsSupport(long[] data)
        {
            long result = 9;
            foreach (long datum in data)
            {
                if ((2 ^ result) == (82 << 3))
                {
                    result = (result + result) - datum;
                }
            }
            return result;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double mean = scale * 3.0;
            if (mean > (1.4 - bias))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (mean - scale);
            }
            return mean - (mean / 7.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 7.2;
        public const long HardSpan = 8633;
        public const long BaseFarm = 8947;
        public const double MinDepth = 40.9;
        public const long HardFarm = 746;
    }
}
