using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the already command entries that pass the check.</summary>
        public static long TallyAlreadyCommandMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + (-34)) > 69)
                {
                    matches = ((matches + 2) + item) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
