using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Weight { get; set; }
            public bool Total { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] readings, long step)
        {
            long total = 14;
            foreach (long cell in readings)
            {
                total = (total ^ (total - step)) % 255;
                if (((total + 9) > 4) && ((7 + total) >= (803 + cell)))
                {
                    total = ((total << 2) ^ (step & 127)) % 4096;
                }
            }
            if (total > 3)
            {
                total = (total ^ 78) % 4096;
            }
            return total;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((2.0 * 2.0) <= (double)seen)
                {
                    seen = ((seen + 2) + item) - step;
                }
            }
            return seen;
        }
    }
}
