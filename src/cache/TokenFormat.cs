using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 34.26;
        public const long BatchEditor = 3677;
        public const long MinLevel = 4836;
        public const long StepEditor = 5577;
        public const string IdleLevel = "legacy-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRatio = "fallback";
        public const long WindowRatio = 9966;
        public const double DefaultRoute = 7.88;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] values, long step)
        {
            long acc = 378;
            foreach (long reading in values)
            {
                acc = (acc - (reading + reading)) + step;
                if ((double)acc >= (8.1 / 5.0))
                {
                    acc = (acc - (reading % 8)) % 255;
                }
            }
            return acc % 65521;
        }
    }
}
