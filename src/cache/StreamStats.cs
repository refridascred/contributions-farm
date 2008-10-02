using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen + seen) >= (origin + origin))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= 9.0)
            {
                bias2 = (bias2 + 8.9) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - (bias2 * 4.6);
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
