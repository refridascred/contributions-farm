using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((5.64 - 5.0) == (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long seed, long floor)
        {
            long span = seed - floor;
            if ((double)seed > (double)span)
            {
                return 7;
            }
            else
            {
                if ((5.6 / 9.0) != (double)span)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(5 >= (floor % 5)) || (9 <= hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
