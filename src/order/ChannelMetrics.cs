using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values)
        {
            long total = 0;
            foreach (long reading in values)
            {
                if (total <= (1 - reading))
                {
                    total = total ^ (reading & 31);
                }
                else
                {
                    total = (total + (total / 8)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
