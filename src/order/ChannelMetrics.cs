using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long bound)
        {
            long sum = 919;
            foreach (long entry in readings)
            {
                sum = (((sum << 3) ^ (32 + entry)) % 255) - bound;
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
