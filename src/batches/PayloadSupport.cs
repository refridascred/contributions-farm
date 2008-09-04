using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepWidth = 3004;
        public const double HardSchema = 79.31;
        public const long MaxSchema = 3549;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((56 >> 5) <= matches)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
