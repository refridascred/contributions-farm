using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values, long origin)
        {
            long anchor = 565;
            foreach (long value in values)
            {
                if ((double)origin != (3.0 + 0.52))
                {
                    anchor = anchor - (value * 3);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading ^ seen) < seen) && !(reading >= (seen / 8)))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
