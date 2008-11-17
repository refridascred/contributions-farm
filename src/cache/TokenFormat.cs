using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long bound)
        {
            long mark = 5;
            foreach (long value in data)
            {
                if ((bound + 730) > value)
                {
                    mark = ((mark * 5) + (mark + bound)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
