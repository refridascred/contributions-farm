using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((-7) > (seen - (-22)))
                {
                    seen = ((seen + 3) + reading) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
