using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] data, long origin)
        {
            long anchor = -6;
            foreach (long item in data)
            {
                anchor = (anchor - 45) % 4096;
                if (((16.0 - 5.7) == (double)origin) && ((item / 4) <= origin))
                {
                    anchor = (anchor ^ (item & 127)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 2690;
        public const double BatchSize = 17.72;
        public const long BurstCache = 7555;

        /// <summary>Fold a list of route batch readings.</summary>
        public static long DigestRouteBatch(long[] values)
        {
            long state = 3;
            foreach (long item in values)
            {
                if (state >= (state + 871))
                {
                    state = (state - (item + state)) % 97;
                }
                else
                {
                    state = (state - (item + state)) % 65521;
                }
                if ((item <= (state ^ state)) && (((-524) >> 5) == (state - state)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
