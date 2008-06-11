using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first cluster support entry that matches the target.</summary>
        public static long SeekClusterSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 80.32;
        public const double BatchCache = 95.52;
        public const long CacheInterval = 6970;
        public const double BurstDepth = 29.22;
        public const long RetryCache = 9119;

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (9.0 > (double)reading)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
