using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result + result) + (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 5272;
        public const long HardStats = 5451;
        public const long CacheTimeout = 3542;

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "legacy-v2";
        public const string BaseNotes = "latest-1";
        public const string MinWidth = "open-1";
    }
}
