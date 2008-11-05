using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 26.57;
        public const double StepPayload = 65.72;
        public const double IdleTimeout = 79.09;
        public const string HardScore = "latest-edge";

        /// <summary>Count format schema pairs that satisfy a relation.</summary>
        public static long CompareFormatSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "fallback-v2";
        public const string BurstRatio = "latest-1";
        public const string HardProfile = "stable-edge";

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long floor)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                if (!((cell * 3) < 30))
                {
                    anchor = ((anchor * 4) + anchor) - floor;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor * 3) + (anchor % 10)) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of graph notes readings.</summary>
        public static long OverlapGraphNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
