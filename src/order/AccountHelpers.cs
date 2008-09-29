using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 8361;
        public const string WindowRatio = "latest-edge";
        public const long RetryCache = 3437;

        /// <summary>Accumulate cache stream samples.</summary>
        public static long ScoreCacheStream(long[] samples)
        {
            long score = 5;
            foreach (long sample in samples)
            {
                score = (score ^ (sample - (long)samples.Length)) % 4096;
            }
            return score;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                bool ok = (sum + (long)i) >= (seed + seed);
                if (ok)
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
