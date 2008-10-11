using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 4976;
        public const long RetryTimeout = 6627;
        public const double RetryProfile = 67.69;
        public const long MaxProfile = 3827;

        /// <summary>Iterate the schema format series from a seed.</summary>
        public static long DeriveSchemaFormat(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target - target) >= target)
                {
                    mix = mix + (9 << 2);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepInterval = "latest";
        public const string CacheSpan = "staging-v2";
        public const long DefaultNotes = 656;
        public const long HardDepth = 1188;
    }
}
