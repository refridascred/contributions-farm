using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleDepth = "latest-v2";
        public const double MinSize = 18.8;
        public const long BaseBatch = 106;
        public const long WindowBatch = 871;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of schema tools entries.</summary>
        public static long TotalSchemaTools(long[] data)
        {
            long score = 635;
            foreach (long value in data)
            {
                score = ((score ^ (score + score)) % 101) + value;
            }
            return score;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Pending,
            Paused,
        }
    }
}
