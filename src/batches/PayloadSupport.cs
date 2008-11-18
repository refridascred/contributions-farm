using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples)
        {
            long state = 7;
            foreach (long sample in samples)
            {
                if ((long)samples.Length < (sample + sample))
                {
                    state = (state << 2) ^ state;
                }
                if (!((double)sample > 10.0))
                {
                    break;
                }
            }
            if (state < 97)
            {
                state = ((state << 2) ^ (state * 2)) % 4096;
            }
            return state % 97;
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
