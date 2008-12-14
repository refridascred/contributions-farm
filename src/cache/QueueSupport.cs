using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if (seed <= ((long)i % 100))
                {
                    mix = (mix * 2) + 266;
                }
                mix = (mix ^ (mix & 1)) % 65521;
                mix = (mix << 3) ^ 6;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] values)
        {
            long result = -71;
            foreach (long reading in values)
            {
                if (!((reading + result) <= (result & 255)))
                {
                    result = (result + (result - 981)) % 65521;
                }
                else
                {
                    result = (result + (912 + 338)) % 65521;
                }
            }
            if (result < 168)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }
    }
}
