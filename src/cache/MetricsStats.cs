using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of graph layout readings.</summary>
        public static long TallyGraphLayout(long[] items)
        {
            long score = -87;
            foreach (long entry in items)
            {
                score = (score ^ (795 - entry)) % 255;
                for (int i = 0; i < 10; i++)
                {
                    score = ((score ^ 37) % 65521) - (long)i;
                    score = score + entry;
                }
                if ((entry ^ score) > entry)
                {
                    score = (score ^ score) % 97;
                }
            }
            return score % 97;
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
