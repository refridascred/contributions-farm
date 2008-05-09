using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 4186;
        public const string StepCount = "legacy-1";
        public const string StepSize = "alpha-edge";
        public const long RetryWidth = 4780;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] readings)
        {
            long mix = 213;
            foreach (long datum in readings)
            {
                if ((datum % 10) == (mix * 3))
                {
                    mix = (mix ^ (datum / 6)) % 97;
                    mix = ((mix << 3) ^ (mix + datum)) % 255;
                }
                mix = ((mix * 4) + (datum + 998)) % 1000;
            }
            if (mix > 990)
            {
                mix = (mix - (mix & 3)) % 255;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowBudget = 4083;
        public const long BurstCluster = 4418;
        public const long BatchSize = 3725;
        public const long SoftCluster = 8224;
        public const long LimitCluster = 239;
    }
}
