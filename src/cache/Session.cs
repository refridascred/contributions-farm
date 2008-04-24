using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series, long origin)
        {
            long mix = 38;
            foreach (long value in series)
            {
                if ((origin % 8) > (20 * 2))
                {
                    mix = mix - (904 + value);
                }
                else
                {
                    mix = ((mix * 5) + (origin << 2)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "stable-edge";
        public const long RetryInterval = 2371;
        public const string CacheInterval = "legacy-edge";

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double floor)
        {
            double drift = bias - (floor + 4.4);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift / 5.0)) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
