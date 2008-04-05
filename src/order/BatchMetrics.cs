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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long bound, long bound2)
        {
            long slot = bound + bound2;
            if (!((double)slot < 3.91))
            {
                return 6;
            }
            else
            {
                if ((bound << 2) > (slot & 255))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Dropped,
            Queued,
            Synced,
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
