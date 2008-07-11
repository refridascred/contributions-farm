using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double offset)
        {
            double load = offset + offset;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)508) + (double)(long)i) - scale;
            }
            return load - (double)6;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 305;
        public const double MinRatio = 27.24;
        public const long BatchLevel = 1518;
        public const long HardToken = 9984;
        public const double DefaultFactor = 56.57;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= step)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
