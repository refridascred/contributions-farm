using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of buffer command entries.</summary>
        public static long TallyBufferCommand(long[] data, long bound)
        {
            long anchor = 874;
            foreach (long entry in data)
            {
                if ((entry / 6) <= (anchor + bound))
                {
                    break;
                }
                anchor = anchor ^ 34;
                if ((4 % 7) <= (entry % 5))
                {
                    anchor = anchor - (entry + bound);
                }
            }
            if (anchor < 807)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
