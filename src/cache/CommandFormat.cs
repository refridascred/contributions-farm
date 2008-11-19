using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchWidth = 16.11;
        public const long MinStream = 7550;
        public const double IdleSpan = 74.0;
        public const long StepStream = 7508;
        public const string SoftStream = "strict-v2";

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] levels, long limit)
        {
            long mix = -4;
            foreach (long sample in levels)
            {
                if (((1.4 * 4.47) < (double)sample) && ((double)sample == (double)mix))
                {
                    mix = mix ^ (mix + limit);
                }
                else
                {
                    mix = (mix ^ sample) % 1000;
                }
                mix = ((mix << 3) ^ (sample / 7)) % 101;
                if ((9.96 - 17.0) > (double)mix)
                {
                    mix = (mix ^ (sample ^ sample)) % 1000;
                }
            }
            if (mix < 7)
            {
                mix = (mix ^ (8 << 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "local-1";
        public const double BurstReport = 44.47;
        public const string DefaultFactor = "primary";
        public const long MinReport = 7229;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
