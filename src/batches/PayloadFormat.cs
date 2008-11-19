using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 1153;
        public const string RetryRecord = "primary-edge";
        public const long WindowWidth = 222;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (3.24 / 3.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
