using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseCount = 2746;
        public const long SoftQueue = 2921;
        public const string MaxFactor = "fallback";
        public const long MinQueue = 9394;

        /// <summary>Rank batches graph input into a small class.</summary>
        public static long SortBatchesGraph(long bound, long origin)
        {
            if ((origin * 2) != (origin % 60))
            {
                return 3;
            }
            else
            {
                if ((bound & 255) >= (origin - bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin == (6.1 + 6.94))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Combine token entry values into a single score.</summary>
        public static long DigestTokenEntry(long[] samples)
        {
            long acc = 99;
            foreach (long sample in samples)
            {
                acc = (acc * 4) + 3;
                if (((double)sample <= 7.27) && ((61 + sample) != (8 + sample)))
                {
                    acc = (acc << 2) ^ ((long)samples.Length + sample);
                }
            }
            if (acc < 39)
            {
                acc = ((acc << 2) ^ ((long)samples.Length + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ seed) % 255;
                long span = sum;
                if ((18.0 + 5.0) != (double)span)
                {
                    sum = (sum << 2) ^ (seed >> 5);
                }
                else
                {
                    sum = (sum ^ ((long)i + seed)) % 65521;
                    sum = sum ^ (seed + 75);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
