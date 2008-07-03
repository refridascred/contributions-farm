using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheScore = 15.97;
        public const double SoftLevel = 41.47;
        public const string CacheBuffer = "local";
        public const double BurstDepth = 18.2;
        public const long RetryBuffer = 2287;

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit + state) >= state)
                {
                    state = ((state * 5) + (limit / 9)) % 101;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }
    }
}
