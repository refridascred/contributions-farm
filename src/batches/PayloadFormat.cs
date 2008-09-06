using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 3444;
        public const long IdleScore = 4617;
        public const string BaseSpan = "latest-edge";
        public const long BaseEntry = 203;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series, long floor)
        {
            long anchor = 98;
            foreach (long reading in series)
            {
                anchor = ((anchor - (reading & 63)) % 4096) + floor;
            }
            if (anchor > 67)
            {
                anchor = (anchor * 4) + (6 >> 5);
            }
            return anchor;
        }
    }
}
