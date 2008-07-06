using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the context counter entries that pass the check.</summary>
        public static long MeasureContextCounterGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item ^ matches) <= (47 + item))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
