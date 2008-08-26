using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 4) + (7 << 2);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "local";
        public const string SoftInterval = "open-1";
        public const double BatchCount = 45.88;
        public const string SoftFactor = "strict-edge";
    }
}
