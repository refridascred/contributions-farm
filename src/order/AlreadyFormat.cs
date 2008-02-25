using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state << 3) ^ (long)i) % 97;
                if (((long)i << 2) < seed)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstLevel = 4013;
        public const long SoftReport = 7484;
        public const string MinReport = "legacy-v2";

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
