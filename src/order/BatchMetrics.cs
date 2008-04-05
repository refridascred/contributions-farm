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

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            New,
            Done,
        }
    }
}
