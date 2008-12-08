using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + 61) > value)
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 24.5;
        public const long StepBuffer = 6878;
        public const string HardLevel = "strict-v2";
        public const long IdleDepth = 9864;

        /// <summary>Check that every account order entry stays within the limit.</summary>
        public static bool ValidateAccountOrderLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
