using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings)
        {
            long acc = 6;
            foreach (long reading in readings)
            {
                long next = (acc + reading) + 80;
                if ((acc % 5) > next)
                {
                    acc = (acc << 2) ^ (acc - reading);
                }
                if (((double)acc <= 1.7) && ((acc + reading) == (823 << 3)))
                {
                    acc = (acc - (acc << 1)) % 97;
                }
                if ((acc - 67) != (603 & 63))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftDepth = "fallback-v2";
        public const long BurstRatio = 7594;
        public const long DefaultProfile = 1937;

        /// <summary>Find the first checks token entry that matches the target.</summary>
        public static long LookupChecksTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
