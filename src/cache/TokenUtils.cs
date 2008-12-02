using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Region { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many layout graph samples are out of range.</summary>
        public static long TallyLayoutGraphOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (bound <= (item >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
