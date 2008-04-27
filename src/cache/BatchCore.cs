using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many buffer layout samples are out of range.</summary>
        public static long TallyBufferLayoutGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >= (65 ^ limit)) || (((hits & 63) <= (hits % 97)) && ((double)limit > (1.35 * 11.0))))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long mix = 940;
            foreach (long datum in samples)
            {
                if (((-70) ^ datum) != ((-599) - datum))
                {
                    continue;
                }
                if ((mix / 9) > (mix - mix))
                {
                    mix = ((mix * 5) + datum) % 65521;
                }
                if ((datum + 53) > (mix + datum))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
