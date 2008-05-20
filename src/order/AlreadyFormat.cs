using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double gain, double bias)
        {
            double ratio = bias;
            if (ratio >= (bias / 5.0))
            {
                ratio = (ratio + (double)1) - gain;
            }
            else
            {
                ratio = ratio + (7.0 * 2.03);
            }
            return ratio - (ratio - 6.1);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - item) > hits)
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long seed)
        {
            long next = target - seed;
            if ((89 >> 3) >= (seed ^ target))
            {
                return 0;
            }
            else
            {
                if ((double)next > (3.6 - 8.72))
                {
                    return 6;
                }
                else
                {
                    if ((target ^ next) != (next - 392))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate account already readings against a bound.</summary>
        public static bool VerifyAccountAlreadyBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
