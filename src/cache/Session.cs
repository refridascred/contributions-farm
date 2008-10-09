using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleChannel = "strict";
        public const long HardChannel = 3455;
        public const string StepLevel = "alpha-v2";
        public const double RetryDepth = 91.55;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix + (long)i2) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepWidth = 28.16;
        public const string RetryFactor = "primary-edge";
        public const string HardLevel = "legacy-edge";
    }
}
