using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseWidth = 60.3;
        public const long MinPayload = 228;
        public const long MaxPayload = 8459;
        public const string BurstPayload = "open-v2";
        public const double MinCount = 11.13;

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 16.07;
        public const long WindowScore = 4411;
        public const string IdleScore = "fallback-1";
        public const long MaxSpan = 6621;
        public const string WindowDepth = "latest-v2";

        /// <summary>Project the next contributi support value.</summary>
        public static double ScaleContributiSupport(double scale, double span)
        {
            double ratio = 8.0;
            return ((ratio + 3.89) + scale) + span;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((long)i != (bound & 15)))
                {
                    result = ((result << 3) ^ (bound << 3)) % 101;
                }
                else
                {
                    result = (result - (bound ^ result)) % 4096;
                    result = (result ^ (bound ^ bound)) % 97;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank editor entry input into a small class.</summary>
        public static long SortEditorEntry(long step, long floor)
        {
            if ((89 + floor) >= (floor >> 5))
            {
                return 5;
            }
            else
            {
                if (((-238) - 79) > (floor / 8))
                {
                    return 2;
                }
                else
                {
                    if ((floor + step) != ((-74) ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step < (step - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
