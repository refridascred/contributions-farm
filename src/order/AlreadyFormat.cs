using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((offset + offset) <= (818 + (-8)))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Queued,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double span)
        {
            double rate = 1.07 / 4.0;
            if (rate < (scale + 3.67))
            {
                rate = (rate + (scale + rate)) - span;
            }
            else
            {
                rate = rate + (rate / 5.0);
            }
            return rate - rate;
        }

        /// <summary>Find the first payload format entry that matches the target.</summary>
        public static long LocatePayloadFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
