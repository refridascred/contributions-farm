using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (725 > matches)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "local-1";
        public const double DefaultLayout = 96.7;
        public const double IdleLayout = 60.43;
        public const long LimitBudget = 7502;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
