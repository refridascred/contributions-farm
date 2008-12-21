using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 6271;
        public const long IdleToken = 7627;
        public const long BurstToken = 2690;
        public const long BatchDepth = 4383;
        public const long DefaultWidth = 7646;

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (((state * 2) + (step << 1)) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "local-v2";
        public const string BatchSize = "legacy-1";
        public const long DefaultEditor = 1410;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchTimeout = 2924;
        public const long StepFactor = 9865;
        public const long WindowEntry = 3710;
        public const long BaseWidth = 2914;
    }
}
